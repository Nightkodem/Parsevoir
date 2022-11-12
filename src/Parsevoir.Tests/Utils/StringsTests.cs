using System.Runtime.CompilerServices;
using FluentAssertions;
using Parsevoir.Utils;

namespace Parsevoir.Tests.Utils;

public class StringsTests
{
    private static readonly ParsingOptions CaseSensitiveOptions = new()
    {
        CaseSensitivity = CaseSensitivity.Sensitive,
    };
    private static readonly ParsingOptions CaseInsensitiveOptions = new()
    {
        CaseSensitivity = CaseSensitivity.Insensitive,
    };
    
    [Theory]
    [InlineData("Jakis tekst do porownania", 0, "Jakis {0} do porownania", 10, 23, 12)]
    [InlineData("Jakiś tekst do porównania", 0, "Jakiś {0} do porównania", 10, 23, 12)]
    [InlineData("Jakiś tekst tekst do porównania", 0, "Jakiś {0} tekst do porównania", 10, 15, 6)]
    [InlineData("Jakiś tekst tekst do porównania", 7, "Jakiś {0} tekst do porównania", 10, 15, 12)]
    [InlineData("Jakiś tekst tekst do porównania", 7, "Jakiś {0} teksest do porównania", 10, 15, -1)]
    public void IndexOf_CaseSensitive_Success(string text, int start, string phrase, int phraseStart, int phraseEnd, int expected)
    {
        int actual = text.IndexOfSubstring(start, phrase, phraseStart, phraseEnd, CaseSensitiveOptions);

        actual.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("Jakis tekst do porownania", 0, "Jakis {0} do PorownaniA", 10, 23, 12)]
    [InlineData("Jakiś tekst do porównania", 0, "Jakiś {0} do porÓwnania", 10, 23, 12)]
    [InlineData("Jakiś tekst tekst do porównania", 7, "Jakiś {0} tEkSt do porównania", 10, 15, 12)]
    public void IndexOf_CaseInsensitive_Success(string text, int start, string phrase, int phraseStart, int phraseEnd, int expected)
    {
        int actual = text.IndexOfSubstring(start, phrase, phraseStart, phraseEnd, CaseInsensitiveOptions);

        actual.Should().Be(expected);
    }
}