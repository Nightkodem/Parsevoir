using System;
using FluentAssertions;
using Xunit;

namespace Parsevoir.Tests.Parses
{
    public class BracketsTests
    {
        [Theory]
        [InlineData("Mała gęś ma 1 metr", "Mała gęś ma {0} metr", 1, 1)]
        [InlineData("Mała gęś ma 1 metr", "Mała gęś ma {{0}} metr", 2, 1)]
        [InlineData("Mała gęś ma 1 metr", "Mała gęś ma {{{0}}} metr", 3, 1)]
        [InlineData("Mała gęś ma 1 metr", "Mała gęś ma {{{{0}}}} metr", 4, 1)]
        public void MultipleBrackets_Success(string source, string template, int bracketsCount, int expectedResult)
        {
            int actualResult = Parse.Single<int>(source, template, bracketsCount);

            actualResult.Should().Be(expectedResult);
        }
    
    
        [Theory]
        [InlineData("Mała gęś ma 1 metr", "Mała gęś ma {0} metr", 0)]
        [InlineData("Mała gęś ma 1 metr", "Mała gęś ma {0} metr", -4)]
        public void MultipleBrackets_ThrowsException(string source, string template, int bracketsCount)
        {
            Action act = () => Parse.Single<int>(source, template, bracketsCount);

            act.Should().Throw<ArgumentException>().WithMessage("*Number of brackets*");
        }
    }
}