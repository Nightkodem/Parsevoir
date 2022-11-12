namespace Parsevoir.Utils;

public struct SplitResult
{
    public string Value { get; init; }
    public int TypeNumber { get; init; }
    
    public SplitResult(string value, int typeNumber)
    {
        Value = value;
        TypeNumber = typeNumber;
    }
}