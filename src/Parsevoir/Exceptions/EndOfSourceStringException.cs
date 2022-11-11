namespace Parsevoir.Exceptions;

public class EndOfSourceStringException : Exception
{
    public string SourceString { get; init; }
    public int SourceIndex { get; init; }

    public EndOfSourceStringException(string message, int sourceIndex, string sourceString)
        : base(message)
    {
        SourceIndex = sourceIndex;
        SourceString = sourceString;
    }
}