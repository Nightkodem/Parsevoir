namespace Parsevoir.Exceptions;

public class OpeningMarkNotFoundException : MarkNotFoundException
{
    public OpeningMarkNotFoundException(int startIndex)
        : base(Opening, startIndex)
    { }
}