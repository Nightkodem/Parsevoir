namespace Parsevoir.Exceptions;

public class MarkNotFoundException : ArgumentException
{
    protected const string Opening = "Optening";
    protected const string Closing = "Closing";

    private const string MessageFormat = "{0} mark not found in template from given index! StartIndex = {1}"; 
    
    public MarkNotFoundException(string? type, int startIndex)
        : base(String.Format(MessageFormat, type, startIndex))
    { }
}