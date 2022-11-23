using System;
using System.Diagnostics.CodeAnalysis;

namespace Parsevoir.Exceptions;

[ExcludeFromCodeCoverage]
public class EndOfTemplateStringException : Exception
{
    public string TemplateString { get; init; }
    public int TemplateIndex { get; init; }

    public EndOfTemplateStringException(string message, int templateIndex, string templateString)
        : base(message)
    {
        TemplateIndex = templateIndex;
        TemplateString = templateString;
    }
}