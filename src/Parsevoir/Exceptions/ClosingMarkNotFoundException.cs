using System.Diagnostics.CodeAnalysis;

namespace Parsevoir.Exceptions;

[ExcludeFromCodeCoverage]
public class ClosingMarkNotFoundException : MarkNotFoundException
{
    public ClosingMarkNotFoundException(int startIndex)
        : base(Closing, startIndex)
    { }
}