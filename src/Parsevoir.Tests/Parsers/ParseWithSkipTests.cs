using System;
using FluentAssertions;
using NUnit.Framework;

namespace Parsevoir.Tests.Parses
{
    public class ParseWithSkipTests
    {
        [Theory]
        [TestCase("Liczba 1 to jest bardzo ciekawa liczba, z 2 powodów.", "Liczba {0} to jest bardzo ciekawa liczba, z {1} powodów.", 1, 2)]
        [TestCase("Liczba 1 to jest bardzo ciekawa liczba, z 2 powodów.", "Liczba {0} to {} liczba, z {1} powodów.", 1, 2)]
        [TestCase("Liczba 1 to jest bardzo ciekawa liczba, z 2 powodów.", "Liczba {0} to {} z {1} powodów.", 1, 2)]
        public void ParseTwoInts_WithSkip_Success(string source, string template, int expected0, int expected1)
        {
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
            var actuals = Parse.Single<int, int>(source, template);
            var actual0 = actuals.Item1;
            var actual1 = actuals.Item2;
#else
            var (actual0, actual1) = Parse.Single<int, int>(source, template);
#endif
            actual0.Should().Be(expected0);
            actual1.Should().Be(expected1);
        }
    
        [Theory]
        [TestCase("1 2 3 jakiś szjs 4 5", "{0} {1} {2} {}s {3} {4}", 1, 2, 3, 4, 5)]
        public void ParseFiveInts_WithSkip_Success(
            string source,
            string template,
            int expected0,
            int expected1,
            int expected2,
            int expected3,
            int expected4)
        {
#if NETSTANDARD2_0 || NETSTANDARD2_1 || NET452
            var (actual0, actual1, actual2, actual3, actual4) =
                Parse.Single<int, int, int, int, int>(source, template);
#else
            var (actual0, actual1, actual2, actual3, actual4) =
                Parse.Single<int, int, int, int, int>(source, template);
#endif

            actual0.Should().Be(expected0);
            actual1.Should().Be(expected1);
            actual2.Should().Be(expected2);
            actual3.Should().Be(expected3);
            actual4.Should().Be(expected4);
        }
    }
}