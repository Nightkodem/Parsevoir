using Parsevoir.Exceptions;

namespace Parsevoir.Utils;

internal class StringSplitter
{
    private static readonly ParsingOptions DefaultParsingOptions = new(StringComparison.Ordinal);

    private readonly string _source;
    private readonly string _template;
    private readonly int _resultCount;
    private readonly int _bracketsCount;
    private readonly ParsingOptions _options;
    
    private int _sourceIndex = 0;
    private int _templateIndex = 0;
    
    internal StringSplitter(string source, string template, int resultCount)
        : this(source, template, resultCount, 1, DefaultParsingOptions)
    { }
    
    internal StringSplitter(string source, string template, int resultCount, int bracketsCount)
        : this(source, template, resultCount, bracketsCount, DefaultParsingOptions)
    { }
    
    internal StringSplitter(string source, string template, int resultCount, ParsingOptions options)
        : this(source, template, resultCount, 1, options)
    { }

    internal StringSplitter(string source, string template, int resultCount, int bracketsCount,
        ParsingOptions options)
    {
        _source = source;
        _template = template;
        _resultCount = resultCount;
        _bracketsCount = bracketsCount;
        _options = options;
    }

    internal SplitResult[] Split()
    {
        var splitResults = new SplitResult[_resultCount];

        for (int i = 0; i < _resultCount; i++)
        {
            string value = GetNext(out int typeIndex);
            var splitResult = new SplitResult(value, typeIndex);
            splitResults[i] = splitResult;
        }

        return splitResults;
    }

    private string GetNext(out int typeIndex)
    {
        var stringComparison = _options.StringComparison;
        var (sourceLength, templateLength) = (_source.Length, _template.Length);

        ValidateIndices(_source, _template, _sourceIndex, _templateIndex, templateLength, sourceLength);

        var (open, close) = Brackets.GetOpenAndCloseString(_bracketsCount);

        int outerStart = _template.IndexOf(open, _templateIndex, stringComparison);
        if (outerStart < 0)
            throw new OpeningMarkNotFoundException(_templateIndex);
        int innerStart = outerStart + _bracketsCount - 1;

        int innerEnd = _template.IndexOf(close, _templateIndex, stringComparison);
        if (innerEnd < 0)
            throw new ClosingMarkNotFoundException(_templateIndex);
        int outerEnd = innerEnd + _bracketsCount - 1;

        string typeIndexSubstring = _template.Substring(innerStart + 1, innerEnd - innerStart - 1);
        typeIndex = Int32.Parse(typeIndexSubstring);

        int nextStart = _template.IndexOf(open, outerEnd, stringComparison);
        if (nextStart < 0) nextStart = _template.Length;

        int sourceStartIndex = _sourceIndex + (outerStart - _templateIndex);
        int sourceEndIndex;

        int afterEnd = innerEnd + _bracketsCount;
        if (afterEnd < _template.Length)
        {
            string followingText = _template.Substring(afterEnd, nextStart - afterEnd);
            sourceEndIndex = _source.IndexOf(followingText, sourceStartIndex, stringComparison);
        }
        else
        {
            sourceEndIndex = _source.Length;
        }

        if (sourceStartIndex >= sourceLength)
            throw new EndOfSourceStringException("End of source string!", sourceStartIndex, _source);

        string resultString = _source.Substring(sourceStartIndex, sourceEndIndex - sourceStartIndex);
        if (String.IsNullOrWhiteSpace(resultString))
            throw new EmptySubstringException("Substring is empty!", _source, sourceStartIndex, sourceEndIndex);

        _templateIndex = afterEnd;
        _sourceIndex = sourceEndIndex;

        return resultString;
    }

    private static void ValidateIndices(string source, string template, int sourceIndex, int templateIndex,
        int templateLength, int sourceLength)
    {
        if (templateIndex >= templateLength)
            throw new EndOfTemplateStringException("End of template string!", templateIndex, template);
        if (sourceIndex >= sourceLength)
            throw new EndOfSourceStringException("End of source string!", sourceIndex, source);
    }
}