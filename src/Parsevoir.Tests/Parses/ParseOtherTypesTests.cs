using FluentAssertions;
using Xunit;

namespace Parsevoir.Tests.Parses
{
    public class ParseOtherTypesTests
    {
        [Theory]
        [InlineData("Prawda: true", "Prawda: {0}", true)]
        [InlineData("Fałśz: False", "Fałśz: {0}", false)]
        public void ParseSingleBoolean_Success(string source, string template, bool expectedResult)
        {
            var actualResult = Parse.Single<bool>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Znak a: a", "Znak a: {0}", 'a')]
        [InlineData("Ukośnik /", "Ukośnik {0}", '/')]
        public void ParseSingleChar_Success(string source, string template, char expectedResult)
        {
            var actualResult = Parse.Single<char>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Byte: 127", "Byte: {0}", (sbyte)127)]
        [InlineData("Minus5 -5", "Minus5 {0}", (sbyte)-5)]
        public void ParseSingleSByte_Success(string source, string template, sbyte expectedResult)
        {
            var actualResult = Parse.Single<sbyte>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Byte: 250", "Byte: {0}", (byte)250)]
        [InlineData("Zero 0", "Zero {0}", (byte)0)]
        public void ParseSingleByte_Success(string source, string template, byte expectedResult)
        {
            var actualResult = Parse.Single<byte>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Int16: 10102", "Int16: {0}", (short)10102)]
        [InlineData("Minus10 -10", "Minus10 {0}", (short)-10)]
        public void ParseSingleInt16_Success(string source, string template, short expectedResult)
        {
            var actualResult = Parse.Single<short>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("UInt16: 10102", "UInt16: {0}", (ushort)10102)]
        [InlineData("Zero 0", "Zero {0}", (ushort)0)]
        public void ParseSingleUInt16_Success(string source, string template, ushort expectedResult)
        {
            var actualResult = Parse.Single<ushort>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Int32: 1010200", "Int32: {0}", (int)1010200)]
        [InlineData("Minus10 -10", "Minus10 {0}", (int)-10)]
        public void ParseSingleInt32_Success(string source, string template, int expectedResult)
        {
            var actualResult = Parse.Single<int>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("UInt32: 1010200", "UInt32: {0}", (uint)1010200)]
        [InlineData("Zero 0", "Zero {0}", (uint)0)]
        public void ParseSingleUInt32_Success(string source, string template, uint expectedResult)
        {
            var actualResult = Parse.Single<uint>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Int64: 10102000000", "Int64: {0}", (long)10102000000)]
        [InlineData("Minus10 -10", "Minus10 {0}", (long)-10)]
        public void ParseSingleInt64_Success(string source, string template, long expectedResult)
        {
            var actualResult = Parse.Single<long>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("UInt64: 1010200000", "UInt64: {0}", (ulong)1010200000)]
        [InlineData("Zero 0", "Zero {0}", (ulong)0)]
        public void ParseSingleUInt64_Success(string source, string template, ulong expectedResult)
        {
            var actualResult = Parse.Single<ulong>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Float: 123.5", "Float: {0}", (float)123.5)]
        [InlineData("Minus10 -10.1", "Minus10 {0}", (float)-10.1)]
        public void ParseSingleFloat_Success(string source, string template, float expectedResult)
        {
            var actualResult = Parse.Single<float>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Double: 123.5321", "Double: {0}", (double)123.5321)]
        [InlineData("Minus10 -10.122", "Minus10 {0}", (double)-10.122)]
        public void ParseSingleDouble_Success(string source, string template, double expectedResult)
        {
            var actualResult = Parse.Single<double>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("Decimal: 123.5321", "Decimal: {0}", 123.5321)]
        [InlineData("Minus10 -10.122", "Minus10 {0}", -10.122)]
        public void ParseSingleDecimal_Success(string source, string template, decimal expectedResult)
        {
            var actualResult = Parse.Single<decimal>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    
        [Theory]
        [InlineData("String: zabawa", "String: {0}", "zabawa")]
        [InlineData("InnyString juhu", "InnyString {0}", "juhu")]
        public void ParseSingleString_Success(string source, string template, string expectedResult)
        {
            var actualResult = Parse.Single<string>(source, template);
            actualResult.Should().Be(expectedResult);
        }
    }
}