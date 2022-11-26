using System;

namespace Parsevoir.Utils;

internal static class Strings
{
    internal static int IndexOfSubstring(
        this ReadOnlySpan<char> text, int start,
        ReadOnlySpan<char> phrase, int phraseStart, int phraseEnd,
        ParsingOptions options)
    {
        int textLength = text.Length;
        int phraseLength = phrase.Length;
        int phraseSubstrLength = phraseEnd - phraseStart;
        ValidateStrings(textLength, start, phraseLength, phraseEnd, phraseSubstrLength);

        bool sensitive = options.CaseSensitivity == CaseSensitivity.Sensitive;
        int lastTextIndex = textLength - phraseSubstrLength;
        for (int i = start; i <= lastTextIndex; i++)
        {
            bool wasMatch = false;
            for (int j = 0; j < phraseSubstrLength; j++)
            {
                char textChar = text[i + j];
                char phraseChar = phrase[phraseStart + j];

                wasMatch = sensitive
                    ? textChar == phraseChar
                    : Char.ToLower(textChar) == Char.ToLower(phraseChar);

                if (!wasMatch) break;
            }
            if (wasMatch) return i;
        }
        
        return -1;
    }

    private static void ValidateStrings(int textLength, int start, int phraseLength, int phraseEnd, int phraseSubstrLength)
    {
        if (phraseEnd > phraseLength)
            throw new Exception("Phrase end index is larger than phrase length!");

        if (start + phraseSubstrLength > textLength)
            throw new Exception("Text end index is larger than text length!");
    }
}