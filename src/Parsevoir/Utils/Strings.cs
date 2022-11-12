﻿using System.Runtime.CompilerServices;

namespace Parsevoir.Utils;

internal static class Strings
{
    internal static int IndexOfSubstring(this string text, int start, string phrase, int phraseStart, int phraseEnd, ParsingOptions options)
    {
        var (textLength, phraseLength) = (text.Length, phrase.Length);
        int phraseSubstrLength = phraseEnd - phraseStart;
        ValidateStrings(textLength, start, phraseLength, phraseEnd, phraseSubstrLength);

        Func<char, char> getChar = options.CaseSensitivity == CaseSensitivity.Sensitive
            ? c => c
            : Char.ToLower;

        var (textArray, phraseArray) = (text.ToCharArray(), phrase.ToCharArray());
        
        int lastTextIndex = textLength - phraseSubstrLength;

        for (int i = start; i <= lastTextIndex; i++)
        {
            bool wasMatch = false;
            for (int j = 0; j < phraseSubstrLength; j++)
            {
                char textChar = getChar(textArray[i + j]);
                char phraseChar = getChar(phraseArray[phraseStart + j]);

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