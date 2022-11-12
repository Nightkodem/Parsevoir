using System.Globalization;

namespace Parsevoir;

public class ParsingOptions
{
    public static readonly ParsingOptions DefaultParsingOptions = new();
    
    public CaseSensitivity CaseSensitivity { get; init; } = CaseSensitivity.Sensitive;
    public NumberFormatInfo NumberFormatInfo { get; init; } = NumberFormatInfo.InvariantInfo;
    public NumberStyles IntegerNumberStyles { get; init; } = NumberStyles.Integer;
    public NumberStyles FloatingNumberStyles { get; init; } = NumberStyles.Float;

    internal StringComparison StringComparison { get; }

    public ParsingOptions()
    {
        StringComparison = CaseSensitivity == CaseSensitivity.Sensitive
            ? StringComparison.Ordinal
            : StringComparison.OrdinalIgnoreCase;
    }

    public void Deconstruct(
        out CaseSensitivity caseSensitivity,
        out StringComparison stringComparison,
        out NumberFormatInfo numberFormatInfo,
        out NumberStyles integerNumberStyles,
        out NumberStyles floatingNumberStyles)
    {
        caseSensitivity = CaseSensitivity;
        stringComparison = StringComparison;
        numberFormatInfo = NumberFormatInfo;
        integerNumberStyles = IntegerNumberStyles;
        floatingNumberStyles = FloatingNumberStyles;
    }
}