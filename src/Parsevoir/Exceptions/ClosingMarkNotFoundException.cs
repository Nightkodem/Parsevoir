namespace Parsevoir.Exceptions;

public class ClosingMarkNotFoundException : MarkNotFoundException
{
    public ClosingMarkNotFoundException(int startIndex)
        : base(Closing, startIndex)
    { }
}