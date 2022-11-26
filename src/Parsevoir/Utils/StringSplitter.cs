using System;
using System.Collections.Generic;
using System.Globalization;
using Parsevoir.Collections;
using Parsevoir.Exceptions;

namespace Parsevoir.Utils;

internal class StringSplitter
{
    private readonly string _source;
    private readonly string _template;
    private readonly int _resultsCount;
    private readonly ParsingOptions _options;
    private readonly string _openMark;
    private readonly string _closeMark;

    private int _sourceIndex = 0;
    private int _templateIndex = 0;
    private int? _nextStart = null;

    internal StringSplitter(string source, string template, int resultsCount)
        : this(source, template, resultsCount, 1, ParsingOptions.DefaultParsingOptions)
    {
    }

    internal StringSplitter(string source, string template, int resultsCount, int bracketsCount)
        : this(source, template, resultsCount, bracketsCount, ParsingOptions.DefaultParsingOptions)
    {
    }

    internal StringSplitter(string source, string template, int resultsCount, ParsingOptions? options)
        : this(source, template, resultsCount, 1, options)
    {
    }

    internal StringSplitter(string source, string template, int resultsCount, int bracketsCount, ParsingOptions? options)
    {
        _source = source;
        _template = template;
        _resultsCount = resultsCount;
        _options = options ?? ParsingOptions.DefaultParsingOptions;
        
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
        var brackets = Brackets.GetOpenAndCloseString(bracketsCount);
        _openMark = brackets.Item1;
        _closeMark = brackets.Item2;
#else
        (_openMark, _closeMark) = Brackets.GetOpenAndCloseString(bracketsCount);
#endif
    }

    internal IReadOnlyDictionary<int, string[]> SplitMany()
    {
        var typesToSplitsCollection = new Dictionary<int, LinkedCollection<string>>();

        bool last = false;
        while (!last)
        {
            string value = GetNext(out int typeNumber, out last);

            bool contains = typesToSplitsCollection.TryGetValue(typeNumber, out var splitsCollection);
            
            splitsCollection ??= new LinkedCollection<string>();
            splitsCollection.Add(value);
            
            if (!contains) typesToSplitsCollection.Add(typeNumber, splitsCollection);
        }
        
        var typesToSplits = new Dictionary<int, string[]>(typesToSplitsCollection.Count);

        foreach (var typeSplitPair in typesToSplitsCollection)
        {
            typesToSplits.Add(typeSplitPair.Key, typeSplitPair.Value.ToArray());
        }

        return typesToSplits;
    }

    internal string[] SplitSingles()
    {
        var splits = new string[_resultsCount];

        for (int i = 0; i < _resultsCount; i++)
        {
            string value = GetNext();
            splits[i] = value;
        }

        return splits;
    }

    private string GetNext()
    {
        return GetNext(out _, out _);
    }

    private string GetNext(out int typeNumber, out bool last)
    {
        bool isSkip = false;
        while (true)
        {
            ValidateIndices();

#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
            var startsAndEnds = GetStartAndEnd();
            int outerStart = startsAndEnds.Item1;
            int start = startsAndEnds.Item2;
            int end = startsAndEnds.Item3;
            int outerEnd = startsAndEnds.Item4;
#else
            var (outerStart, start, end, outerEnd) = GetStartAndEnd();
#endif

            bool wasSkip = isSkip;
            isSkip = start == end;
            if (isSkip)
            {
                _templateIndex = outerEnd + 1;
                _nextStart = null;
                continue;
            }

            typeNumber = GetTypeNumber(start, end);

            _nextStart = GetNextStart(outerEnd);

#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
            var sourceStartAndEnd = GetSourceStartAndEnd(outerStart, outerEnd, _nextStart.Value, wasSkip);
            int sourceStart = sourceStartAndEnd.Item1;
            int sourceEnd = sourceStartAndEnd.Item2;
#else
            var (sourceStart, sourceEnd) = GetSourceStartAndEnd(outerStart, outerEnd, _nextStart.Value, wasSkip);
#endif

            string resultString = _source.Substring(sourceStart, sourceEnd - sourceStart);
            if (String.IsNullOrWhiteSpace(resultString))
                throw new EmptySubstringException("Substring is empty!", _source, sourceStart, sourceEnd);

            _templateIndex = outerEnd + 1;
            _sourceIndex = sourceEnd;

            last = _nextStart.Value == _template.Length;
            return resultString;
        }
    }

    private void ValidateIndices()
    {
        if (_templateIndex >= _template.Length)
            throw new EndOfTemplateStringException("End of template string!", _templateIndex, _template);
        
        if (_sourceIndex >= _source.Length)
            throw new EndOfSourceStringException("End of source string!", _sourceIndex, _source);
    }

#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
    private Tuple<int, int, int, int> GetStartAndEnd()
#else
    private (int outerStart, int start, int end, int outerEnd) GetStartAndEnd()
#endif
    {
        int outerStart = _nextStart ?? _template.IndexOf(_openMark, _templateIndex, _options.StringComparison);
        if (outerStart < 0)
            throw new OpeningMarkNotFoundException(_templateIndex);
        int start = outerStart + _openMark.Length;

        int end = _template.IndexOf(_closeMark, start, _options.StringComparison);
        if (end < 0)
            throw new ClosingMarkNotFoundException(start);
        int outerEnd = end + _closeMark.Length - 1;

#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
        return new Tuple<int, int, int, int>(outerStart, start, end, outerEnd);
#else
        return (outerStart, start, end, outerEnd);
#endif
    }

    private int GetTypeNumber(int start, int end)
    {
        string typeIndexSubstring = _template.Substring(start, end - start);
        int typeIndex = Int32.Parse(typeIndexSubstring, _options.IntegerNumberStyles, _options.NumberFormatInfo);
        return typeIndex;
    }

#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
    private Tuple<int, int> GetSourceStartAndEnd(int outerStart, int outerEnd, int nextStart, bool wasSkip)
#else
    private (int sourceStart, int sourceEnd) GetSourceStartAndEnd(int outerStart, int outerEnd, int nextStart, bool wasSkip)
#endif
    {
        ReadOnlySpan<char> sourceAsSpan = _source;
        ReadOnlySpan<char> templateAsSpan = _template;
        
        int templateStartOffset = outerStart - _templateIndex;
        int sourceStart = wasSkip
            ? sourceAsSpan.IndexOfSubstring(_sourceIndex, templateAsSpan, _templateIndex, outerStart, _options) + templateStartOffset
            : _sourceIndex + templateStartOffset;

        if (sourceStart >= _source.Length)
            throw new EndOfSourceStringException("End of source string!", sourceStart, _source);

        bool iseEndOfString = outerEnd + 1 >= _template.Length;
        int sourceEnd = iseEndOfString
            ? _source.Length
            : sourceAsSpan.IndexOfSubstring(sourceStart, templateAsSpan, outerEnd + 1, nextStart, _options);
        
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
        return new Tuple<int, int>(sourceStart, sourceEnd);
#else
        return (sourceStart, sourceEnd);
#endif
    }

    private int GetNextStart(int outerEnd)
    {
        int nextStart = _template.IndexOf(_openMark, outerEnd, _options.StringComparison);
        return nextStart >= 0 ? nextStart : _template.Length;
    }
}