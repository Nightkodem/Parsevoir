using System;
using FluentAssertions;
using Parsevoir.Exceptions;
using Xunit;

namespace Parsevoir.Tests.Parses
{
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
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452
            var (actual0, actual1) = Parse.Single<int, int>(source, template);
#else
            var (actual0, actual1) = Parse.Single<int, int>(source, template);
#endif

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
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452
            var (actual0, actual1, actual2) = Parse.Single<int, int, int>(source, template);
#else
            var (actual0, actual1, actual2) = Parse.Single<int, int, int>(source, template);
#endif

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
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452
            var (actual0, actual1, actual2, actual3) = Parse.Single<int, int, int, int>(source, template);
#else
            var (actual0, actual1, actual2, actual3) = Parse.Single<int, int, int, int>(source, template);
#endif

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
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452
            var (actual0, actual1, actual2, actual3, actual4) = Parse.Single<int, int, int, int, int>(source, template);
#else
            var (actual0, actual1, actual2, actual3, actual4) = Parse.Single<int, int, int, int, int>(source, template);
#endif

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
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452
            var (actual0, actual1, actual2, actual3, actual4, actual5) =
                Parse.Single<int, int, int, int, int, int>(source, template);
#else
            var (actual0, actual1, actual2, actual3, actual4, actual5) =
                Parse.Single<int, int, int, int, int, int>(source, template);
#endif

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
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452
            var (actual0, actual1, actual2, actual3, actual4, actual5, actual6) =
                Parse.Single<int, int, int, int, int, int, int>(source, template);
#else
            var (actual0, actual1, actual2, actual3, actual4, actual5, actual6) =
                Parse.Single<int, int, int, int, int, int, int>(source, template);
#endif

            actual0.Should().Be(expected0);
            actual1.Should().Be(expected1);
            actual2.Should().Be(expected2);
            actual3.Should().Be(expected3);
            actual4.Should().Be(expected4);
            actual5.Should().Be(expected5);
            actual6.Should().Be(expected6);
        }

#if !(NETSTANDARD2_0 || NETSTANDARD2_1 || NET45 || NET451 || NET452)
        
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
#endif

        [Fact]
        public void ParseSingleInt_WrongOpeningBracketFormat_ThrowsException()
        {
            Action act = () => Parse.Single<int>("Liczba 12", "Liczba 0}");

            act.Should().Throw<OpeningMarkNotFoundException>();
        }

        [Fact]
        public void ParseSingleInt_WrongClosingBracketFormat_ThrowsException()
        {
            Action act = () => Parse.Single<int>("Liczba 12", "Liczba {0");

            act.Should().Throw<ClosingMarkNotFoundException>();
        }

        [Fact]
        public void ParseSingleInt_WrongSourceFormat_ThrowsException()
        {
            Action act = () => Parse.Single<int>("Liczb", "Liczba {0}");

            act.Should().Throw<EndOfSourceStringException>();
        }

        [Fact]
        public void ParseSingleInt_WrongTemplateFormat_ThrowsException()
        {
            Action act = () => Parse.Single<int, int>("Liczba 12 i 13", "Liczba {0}");

            act.Should().Throw<EndOfTemplateStringException>();
        }

        [Fact]
        public void ParseSingleInt_EmptyResult_ThrowsException()
        {
            Action act = () => Parse.Single<int>("Liczba  nie ma liczby", "Liczba {0} nie ma liczby");

            act.Should().Throw<EmptySubstringException>();
        }
    }
}