using System;

namespace Parsevoir.Utils;

internal static class Strings
{
    internal static int IndexOfSubstring(
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48
        this string text, int start, string phrase,
#else
        this ReadOnlySpan<char> text, int start, ReadOnlySpan<char> phrase,
#endif
            int phraseStart, int phraseEnd, ParsingOptions options)
    {
        var textLength = text.Length;
        var phraseLength = phrase.Length;
        int phraseSubstrLength = phraseEnd - phraseStart;
        ValidateStrings(textLength, start, phraseLength, phraseEnd, phraseSubstrLength);

        Func<char, char> getChar = options.CaseSensitivity == CaseSensitivity.Sensitive
            ? c => c
            : Char.ToLower;
        
        int lastTextIndex = textLength - phraseSubstrLength;

        for (int i = start; i <= lastTextIndex; i++)
        {
            bool wasMatch = false;
            for (int j = 0; j < phraseSubstrLength; j++)
            {
                char textChar = getChar(text[i + j]);
                char phraseChar = getChar(phrase[phraseStart + j]);

                wasMatch = textChar == phraseChar;
                if (!wasMatch) break;
            }
            if (wasMatch) return i;
        }
        
        return -1;
    }

    private static void ValidateStrings( int textLength, int start, int phraseLength, int phraseEnd, int phraseSubstrLength)
    {
        if (phraseEnd > phraseLength)
            throw new Exception("Phrase end index is larger than phrase length!");

        if (start + phraseSubstrLength > textLength)
            throw new Exception("Text end index is larger than text length!");
    }
}