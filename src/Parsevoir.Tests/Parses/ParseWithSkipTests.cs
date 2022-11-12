using FluentAssertions;

namespace Parsevoir.Tests.Parses;

public class ParseWithSkipTests
{
    [Theory]
    [InlineData("Liczba 1 to jest bardzo ciekawa liczba, z 2 powodów.", "Liczba {0} to jest bardzo ciekawa liczba, z {1} powodów.", 1, 2)]
    [InlineData("Liczba 1 to jest bardzo ciekawa liczba, z 2 powodów.", "Liczba {0} to {} liczba, z {1} powodów.", 1, 2)]
    [InlineData("Liczba 1 to jest bardzo ciekawa liczba, z 2 powodów.", "Liczba {0} to {} z {1} powodów.", 1, 2)]
    public void ParseTwoInts_WithSkip_Success(string source, string template, int expected0, int expected1)
    {
        var (actual0, actual1) = Parse.Single<int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
    }
    
    [Theory]
    [InlineData("1 2 3 jakiś szjs 4 5", "{0} {1} {2} {}s {3} {4}", 1, 2, 3, 4, 5)]
    public void ParseFiveInts_WithSkip_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3,
        int expected4)
    {
        var (actual0, actual1, actual2, actual3, actual4) =
            Parse.Single<int, int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
        actual4.Should().Be(expected4);
    }
}