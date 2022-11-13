using System;
using System.Diagnostics.CodeAnalysis;

namespace Parsevoir.Exceptions;

[ExcludeFromCodeCoverage]
public class WeirdException : Exception
{
    private const string Tail = " Should not have happened!";
    
    public WeirdException(string? message)
        : base(message + Tail)
    { }
}