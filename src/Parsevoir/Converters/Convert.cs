using System;
using System.Collections.Generic;
using System.Linq;
using Parsevoir.Compatibility;

namespace Parsevoir.Converters;

internal class Convert
{
    private static readonly Dictionary<Type, TypeCode> TypeCodes = new()
    {
        { typeof(bool), TypeCode.Boolean },
        { typeof(char), TypeCode.Char },
        { typeof(sbyte), TypeCode.SByte },
        { typeof(byte), TypeCode.Byte },
        { typeof(short), TypeCode.Int16 },
        { typeof(ushort), TypeCode.UInt16 },
        { typeof(int), TypeCode.Int32 },
        { typeof(uint), TypeCode.UInt32 },
        { typeof(long), TypeCode.Int64 },
        { typeof(ulong), TypeCode.UInt64 },
        { typeof(float), TypeCode.Single },
        { typeof(double), TypeCode.Double },
        { typeof(decimal), TypeCode.Decimal },
        { typeof(DateTime), TypeCode.DateTime },
        { typeof(string), TypeCode.String },
    };

    private readonly ParsingOptions _options;

    public Convert(ParsingOptions options)
    {
        _options = options;
    }

    internal T[] To<T>(IReadOnlyDictionary<int, IEnumerable<string>> typesToSplits, int typeNumber)
    {
        return typesToSplits.TryGetValue(typeNumber, out IEnumerable<string>? splits)
            ? To<T>(splits)
            : EmptyArray.Value<T>();
    }

    internal T[] To<T>(IEnumerable<string> splits, TypeCode? typeCode = null)
    {
        typeCode ??= GetTypeCodeSafe<T>();
        
        T[] values = splits
            .Select(split => To<T>(split, typeCode))
            .ToArray();
        
        return values;
    }

    internal T To<T>(string split, TypeCode? typeCode = null)
    {
        object value = ToObjectOf<T>(split, typeCode);
        return (T)value;
    }

    internal object ToObjectOf<T>(string text, TypeCode? typeCode = null)
    {
        typeCode ??= GetTypeCodeSafe<T>();
        return typeCode switch
        {
            TypeCode.Boolean => Boolean.Parse(text),
            TypeCode.Char => Char.Parse(text),
            TypeCode.SByte => SByte.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.Byte => Byte.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.Int16 => Int16.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.UInt16 => UInt16.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.Int32 => Int32.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.UInt32 => UInt32.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.Int64 => Int64.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.UInt64 => UInt64.Parse(text, _options.IntegerNumberStyles, _options.NumberFormatInfo),
            TypeCode.Single => Single.Parse(text, _options.FloatingNumberStyles, _options.NumberFormatInfo),
            TypeCode.Double => Double.Parse(text, _options.FloatingNumberStyles, _options.NumberFormatInfo),
            TypeCode.Decimal => Decimal.Parse(text, _options.FloatingNumberStyles, _options.NumberFormatInfo),
            TypeCode.DateTime => _options.DateTimeFormatString is null
                ? DateTime.Parse(text, _options.DateTimeFormatInfo, _options.DateTimeStyles)
                : DateTime.ParseExact(text, _options.DateTimeFormatString, _options.DateTimeFormatInfo, _options.DateTimeStyles),
            TypeCode.String => text,
            TypeCode.Object => text,
            _ => throw new ArgumentOutOfRangeException(nameof(typeCode), $"Invalid type passed! Type: {typeof(T).FullName}")
        };
    }

    private static TypeCode GetTypeCodeSafe<T>() => TypeCodes.TryGetValue(typeof(T), out TypeCode typeCode)
        ? typeCode
        : TypeCode.Empty;
}