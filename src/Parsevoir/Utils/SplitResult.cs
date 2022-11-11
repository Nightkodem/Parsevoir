namespace Parsevoir.Utils;

public struct SplitResult
{
    public string Value { get; init; }
    public int TypeIndex { get; init; }
    
    public SplitResult(string value, int typeIndex)
    {
        Value = value;
        TypeIndex = typeIndex;
    }
}