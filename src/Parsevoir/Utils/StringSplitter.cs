using Parsevoir.Exceptions;

namespace Parsevoir.Utils;

internal static class StringSplitter
{
    private static readonly ParsingOptions DefaultParsingOptions = new(StringComparison.Ordinal);

    internal static string[] Split(string source, string template, int resultCount, int bracketsCount = 1,
        ParsingOptions? options = null)
    {
        var (open, close) = Brackets.GetOpenAndCloseString(bracketsCount);

        options ??= DefaultParsingOptions;

        string[] results = new string[resultCount];

        int sourceIndex = 0;
        int templateIndex = 0;
        for (int i = 0; i < resultCount; i++)
        {
            string result = GetNext(source, template, ref sourceIndex, ref templateIndex, open, close, options, out _);
            results[i] = result;
        }

        return results;
    }

    private static string GetNext(
        string source, string template,
        ref int sourceIndex, ref int templateIndex,
        string open, string close,
        ParsingOptions parsingOptions, out int typeIndex)
    {
        var stringComparison = parsingOptions.StringComparison;
        var (sourceLength, templateLength) = (source.Length, template.Length);
        if (templateIndex >= templateLength)
            throw new EndOfTemplateStringException("End of template string!", templateIndex, template);
        if (sourceIndex >= sourceLength)
            throw new EndOfSourceStringException("End of source string!", sourceIndex, source);

        int bracketsCount = open.Length == close.Length ? open.Length : throw new WeirdException("Open and close brackets length have different sizes!");

        int outerStart = template.IndexOf(open, templateIndex, stringComparison);
        if (outerStart < 0)
            throw new OpeningMarkNotFoundException(templateIndex);
        int innerStart = outerStart + bracketsCount - 1;

        int innerEnd = template.IndexOf(close, templateIndex, stringComparison);
        if (innerEnd < 0)
            throw new ClosingMarkNotFoundException(templateIndex);
        int outerEnd = innerEnd + bracketsCount - 1;

        string typeIndexSubstring = template.Substring(innerStart + 1, innerEnd - innerStart - 1);
        typeIndex = Int32.Parse(typeIndexSubstring);

        int nextStart = template.IndexOf(open, outerEnd, stringComparison);
        if (nextStart < 0) nextStart = template.Length;

        int sourceStartIndex = sourceIndex + (outerStart - templateIndex);
        int sourceEndIndex;

        int afterEnd = innerEnd + bracketsCount;
        if (afterEnd < template.Length)
        {
            string followingText = template.Substring(afterEnd, nextStart - afterEnd);
            sourceEndIndex = source.IndexOf(followingText, sourceStartIndex, stringComparison);
        }
        else
        {
            sourceEndIndex = source.Length;
        }

        if (sourceStartIndex >= sourceLength)
            throw new EndOfSourceStringException("End of source string!", sourceStartIndex, source);

        string resultString = source.Substring(sourceStartIndex, sourceEndIndex - sourceStartIndex);
        if (String.IsNullOrWhiteSpace(resultString))
            throw new EmptySubstringException("Substring is empty!", source, sourceStartIndex, sourceEndIndex);

        templateIndex = afterEnd;
        sourceIndex = sourceEndIndex;

        return resultString;
    }
}