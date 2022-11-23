using System;
using FluentAssertions;
using Xunit;

namespace Parsevoir.Tests.Parses
{
    public class ParseManyTests
    {
        [Theory]
        [InlineData("1 2 3", "{0} {0} {0}", 1, 2, 3)]
        [InlineData("Magda ma 12 lat, Bartek 7, a Dumbledore 623", "Magda ma {0} lat, Bartek {0}, a Dumbledore {0}", 12, 7, 623)]
        public void ParseManyInts_Success(string source, string template, int expected0, int expected1, int expected2)
        {
            int[] actuals = Parse.Many<int>(source, template);

            actuals.Should().HaveCount(3);

            actuals[0].Should().Be(expected0);
            actuals[1].Should().Be(expected1);
            actuals[2].Should().Be(expected2);
        }

        [Theory]
        [InlineData("1 łapeć 2.3 4", "{0} {1} {2} {0}", 1, "łapeć", 2.3, 4)]
        public void ParseManyDifferents_Success(string source, string template, int expected0, string expected1,
            float expected2, int expected3)
        {
            var (actuals0, actuals1, actuals2) =
                Parse.Many<int, string, float>(source, template);

            actuals0.Should().HaveCount(2);
            actuals1.Should().HaveCount(1);
            actuals2.Should().HaveCount(1);

            actuals0[0].Should().Be(expected0);
            actuals0[1].Should().Be(expected3);
            actuals1[0].Should().Be(expected1);
            actuals2[0].Should().Be(expected2);
        }

        [Theory]
        [InlineData("1 łapeć 2 4", "{0} {1} {0} {0}", 1, "łapeć", 2, 4)]
        public void ParseManyDifferentsWithOneEmpty_Success(string source, string template, int expected0,
            string expected1, int expected2, int expected3)
        {
            var (actuals0, actuals1, actuals2) =
                Parse.Many<int, string, float>(source, template);

            actuals0.Should().HaveCount(3);
            actuals1.Should().HaveCount(1);
            actuals2.Should().HaveCount(0);

            actuals0[0].Should().Be(expected0);
            actuals0[1].Should().Be(expected2);
            actuals0[2].Should().Be(expected3);
            actuals1[0].Should().Be(expected1);
        }
    }
}