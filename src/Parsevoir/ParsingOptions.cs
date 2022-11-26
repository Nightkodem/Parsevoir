using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Parsevoir;

public class ParsingOptions
{
    public static readonly ParsingOptions DefaultParsingOptions = new();
    
    public CaseSensitivity CaseSensitivity { get; init; } = CaseSensitivity.Sensitive;
    public NumberFormatInfo NumberFormatInfo { get; init; } = NumberFormatInfo.InvariantInfo;
    public NumberStyles IntegerNumberStyles { get; init; } = NumberStyles.Integer;
    public NumberStyles FloatingNumberStyles { get; init; } = NumberStyles.Float;
    public string? DateTimeFormatString { get; init; } = null;
    public DateTimeFormatInfo DateTimeFormatInfo { get; init; } = DateTimeFormatInfo.InvariantInfo;
    public DateTimeStyles DateTimeStyles { get; init; } = DateTimeStyles.AllowWhiteSpaces;
    internal StringComparison StringComparison { get; }

    public ParsingOptions()
    {
        StringComparison = CaseSensitivity == CaseSensitivity.Sensitive
            ? StringComparison.Ordinal
            : StringComparison.OrdinalIgnoreCase;
    }
    
    internal ParsingOptions(CaseSensitivity caseSensitivity)
    {
        CaseSensitivity = caseSensitivity;
        StringComparison = CaseSensitivity == CaseSensitivity.Sensitive
            ? StringComparison.Ordinal
            : StringComparison.OrdinalIgnoreCase;
    }
}