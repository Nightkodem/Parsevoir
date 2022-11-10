using Parsevoir.Exceptions;

namespace Parsevoir.Utils;

internal static class StringSplitter
{
    private static readonly ParseOptions DefaultParseOptions = new(StringComparison.Ordinal);
    
    internal static string[] Split(string source, string template, int resultCount, int bracketsCount = 1, ParseOptions? options = null)
    {
        var (open, close) = Brackets.GetOpenAndCloseString(bracketsCount);

        options ??= DefaultParseOptions;
        
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
        ParseOptions parseOptions, out int typeIndex)
    {
        var stringComparison = parseOptions.StringComparison;
        var (sourceLength, templateLength) = (source.Length, template.Length);
        if (sourceIndex >= sourceLength || templateIndex >= templateLength)
            throw new Exception("End of string!");
        
        int start = template.IndexOf(open, templateIndex, stringComparison);
        if (start < 0)
            throw new OpeningMarkNotFoundException(templateIndex);
        
        int end = template.IndexOf(close, templateIndex, stringComparison);
        if (end < 0)
            throw new ClosingMarkNotFoundException(templateIndex);

        string typeIndexSubstring = template.Substring(start + 1, end - start - 1);
        typeIndex = Int32.Parse(typeIndexSubstring);

        int nextStart = template.IndexOf(open, end, stringComparison);
        if (nextStart < 0) nextStart = template.Length;

        int sourceStartIndex = sourceIndex + (start - templateIndex);
        int sourceEndIndex;
        
        int afterEnd = end + 1;
        if (afterEnd < template.Length)
        {
            string followingText = template.Substring(afterEnd, nextStart - afterEnd);
            sourceEndIndex = source.IndexOf(followingText, sourceStartIndex, stringComparison);
        }
        else
        {
            sourceEndIndex = source.Length;
        }

        string resultString = source.Substring(sourceStartIndex, sourceEndIndex - sourceStartIndex);
        if (String.IsNullOrWhiteSpace(resultString))
            throw new Exception("Result is empty!");

        templateIndex = afterEnd;
        sourceIndex = sourceEndIndex;
        
        return resultString;
    }
}

















