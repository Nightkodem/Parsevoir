﻿namespace Parsevoir.Exceptions;

public class WeirdException : Exception
{
    private const string Tail = " Should not have happened!";
    
    public WeirdException(string? message)
        : base(message + Tail)
    { }
}