using FluentAssertions;

namespace Parsevoir.Tests.Parses;

public class ParseSingleTests
{
    [Theory]
    [InlineData("123", "{0}", 123)]
    [InlineData("Liczba 12 jest mała", "Liczba {0} jest mała", 12)]
    public void ParseSingleOneInt_Success(
        string source,
        string template,
        int expectedResult)
    {
        int actualResult = Parse.Single<int>(source, template);

        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("123 321", "{0} {1}", 123, 321)]
    [InlineData("Liczba 12 jest mała, a liczba 87 bardzo duża.", "Liczba {0} jest mała, a liczba {1} bardzo duża.", 12, 87)]
    [InlineData("Liczba 12 jest mała, a liczba 87", "Liczba {0} jest mała, a liczba {1}", 12, 87)]
    [InlineData("1234 jest mała, a liczba 8", "{0} jest mała, a liczba {1}", 1234, 8)]
    public void ParseSingleTwoInts_Success(
        string source,
        string template,
        int expected0,
        int expected1)
    {
        var (actual0, actual1) = Parse.Single<int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
    }

    [Theory]
    [InlineData("1 2 3", "{0} {1} {2}", 1, 2, 3)]
    [InlineData("Liczba3jestmniejsza niż 4, ale większa od2", "Liczba{0}jestmniejsza niż {1}, ale większa od{2}", 3, 4, 2)]
    public void ParseSingleThreeInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2)
    {
        var (actual0, actual1, actual2) = Parse.Single<int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
    }

    [Theory]
    [InlineData("1 2 3 4", "{0} {1} {2} {3}", 1, 2, 3, 4)]
    public void ParseSingleFourInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3)
    {
        var (actual0, actual1, actual2, actual3) = Parse.Single<int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
    }

    [Theory]
    [InlineData("1 2 3 4 5", "{0} {1} {2} {3} {4}", 1, 2, 3, 4, 5)]
    public void ParseSingleFiveInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3,
        int expected4)
    {
        var (actual0, actual1, actual2, actual3, actual4) = Parse.Single<int, int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
        actual4.Should().Be(expected4);
    }

    [Theory]
    [InlineData("1 2 3 4 5 6", "{0} {1} {2} {3} {4} {5}", 1, 2, 3, 4, 5, 6)]
    public void ParseSingleSixInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3,
        int expected4,
        int expected5)
    {
        var (actual0, actual1, actual2, actual3, actual4, actual5) =
            Parse.Single<int, int, int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
        actual4.Should().Be(expected4);
        actual5.Should().Be(expected5);
    }

    [Theory]
    [InlineData("1 2 3 4 5 6 7", "{0} {1} {2} {3} {4} {5} {6}", 1, 2, 3, 4, 5, 6, 7)]
    public void ParseSingleSevenInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3,
        int expected4,
        int expected5,
        int expected6)
    {
        var (actual0, actual1, actual2, actual3, actual4, actual5, actual6) =
            Parse.Single<int, int, int, int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
        actual4.Should().Be(expected4);
        actual5.Should().Be(expected5);
        actual6.Should().Be(expected6);
    }

    [Theory]
    [InlineData("1 2 3 4 5 6 7 8", "{0} {1} {2} {3} {4} {5} {6} {7}", 1, 2, 3, 4, 5, 6, 7, 8)]
    public void ParseSingleEightInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3,
        int expected4,
        int expected5,
        int expected6,
        int expected7)
    {
        var (actual0, actual1, actual2, actual3, actual4, actual5, actual6, actual7) =
            Parse.Single<int, int, int, int, int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
        actual4.Should().Be(expected4);
        actual5.Should().Be(expected5);
        actual6.Should().Be(expected6);
        actual7.Should().Be(expected7);
    }

    [Theory]
    [InlineData("1 2 3 4 5 6 7 8 9", "{0} {1} {2} {3} {4} {5} {6} {7} {8}", 1, 2, 3, 4, 5, 6, 7, 8, 9)]
    public void ParseSingleNineInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3,
        int expected4,
        int expected5,
        int expected6,
        int expected7,
        int expected8)
    {
        var (actual0, actual1, actual2, actual3, actual4, actual5, actual6, actual7, actual8) =
            Parse.Single<int, int, int, int, int, int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
        actual4.Should().Be(expected4);
        actual5.Should().Be(expected5);
        actual6.Should().Be(expected6);
        actual7.Should().Be(expected7);
        actual8.Should().Be(expected8);
    }

    [Theory]
    [InlineData("1 2 3 4 5 6 7 8 9 10", "{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
    public void ParseSingleTenInts_Success(
        string source,
        string template,
        int expected0,
        int expected1,
        int expected2,
        int expected3,
        int expected4,
        int expected5,
        int expected6,
        int expected7,
        int expected8,
        int expected9)
    {
        var (actual0, actual1, actual2, actual3, actual4, actual5, actual6, actual7, actual8, actual9) =
            Parse.Single<int, int, int, int, int, int, int, int, int, int>(source, template);

        actual0.Should().Be(expected0);
        actual1.Should().Be(expected1);
        actual2.Should().Be(expected2);
        actual3.Should().Be(expected3);
        actual4.Should().Be(expected4);
        actual5.Should().Be(expected5);
        actual6.Should().Be(expected6);
        actual7.Should().Be(expected7);
        actual8.Should().Be(expected8);
        actual9.Should().Be(expected9);
    }
}