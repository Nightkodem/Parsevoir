using System.Diagnostics.CodeAnalysis;

namespace Parsevoir.Exceptions;

[ExcludeFromCodeCoverage]
public class OpeningMarkNotFoundException : MarkNotFoundException
{
    public OpeningMarkNotFoundException(int startIndex)
        : base(Opening, startIndex)
    { }
}