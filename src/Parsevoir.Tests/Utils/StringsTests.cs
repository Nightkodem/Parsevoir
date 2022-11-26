using System;
using FluentAssertions;
using Parsevoir.Utils;
using NUnit.Framework;

namespace Parsevoir.Tests.Utils
{
    public class StringsTests
    {
        private static readonly ParsingOptions CaseSensitiveOptions = new ParsingOptions(CaseSensitivity.Sensitive);
        private static readonly ParsingOptions CaseInsensitiveOptions = new ParsingOptions(CaseSensitivity.Insensitive);
    
        [Theory]
        [TestCase("Jakis tekst do porownania", 0, "Jakis {0} do porownania", 10, 23, 12)]
        [TestCase("Jakiś tekst do porównania", 0, "Jakiś {0} do porównania", 10, 23, 12)]
        [TestCase("Jakiś tekst tekst do porównania", 0, "Jakiś {0} tekst do porównania", 10, 15, 6)]
        [TestCase("Jakiś tekst tekst do porównania", 7, "Jakiś {0} tekst do porównania", 10, 15, 12)]
        [TestCase("Jakiś tekst tekst do porównania", 7, "Jakiś {0} teksest do porównania", 10, 15, -1)]
        public void IndexOf_CaseSensitive_Success(string text, int start, string phrase, int phraseStart, int phraseEnd, int expected)
        {
            ReadOnlySpan<char> textAsSpan = text;
            
            int actual = textAsSpan.IndexOfSubstring(start, phrase, phraseStart, phraseEnd, CaseSensitiveOptions);

            actual.Should().Be(expected);
        }
    
        [Theory]
        [TestCase("Jakis tekst do porownania", 0, "Jakis {0} do PorownaniA", 10, 23, 12)]
        [TestCase("Jakiś tekst do porównania", 0, "Jakiś {0} do porÓwnania", 10, 23, 12)]
        [TestCase("Jakiś tekst tekst do porównania", 7, "Jakiś {0} tEkSt do porównania", 10, 15, 12)]
        public void IndexOf_CaseInsensitive_Success(string text, int start, string phrase, int phraseStart, int phraseEnd, int expected)
        {
            ReadOnlySpan<char> textAsSpan = text;
            
            int actual = textAsSpan.IndexOfSubstring(start, phrase, phraseStart, phraseEnd, CaseInsensitiveOptions);

            actual.Should().Be(expected);
        }
    }
}