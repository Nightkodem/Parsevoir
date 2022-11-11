using System.Diagnostics.CodeAnalysis;

namespace Parsevoir.Exceptions;

[ExcludeFromCodeCoverage]
public class EmptySubstringException : Exception
{
    public string SourceString { get; init; }
    public int StartIndex { get; init; }
    public int EndIndex { get; init; }

    public EmptySubstringException(string message, string sourceString, int startIndex, int endIndex)
        : base(message)
    {
        SourceString = sourceString;
        StartIndex = startIndex;
        EndIndex = endIndex;
    }
}