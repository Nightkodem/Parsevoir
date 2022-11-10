using System.Runtime.CompilerServices;

namespace Parsevoir.Converters;

internal static class CustomConverter
{
    private static readonly IReadOnlyDictionary<Type, TypeCode> TypeCodes = new Dictionary<Type, TypeCode>
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
        { typeof(String), TypeCode.String },
    };

    internal static T Convert<T>(string text)
    {
        TypeCode typeCode = TypeCodes[typeof(T)];

        return typeCode switch
        {
            TypeCode.Boolean => (T) (object) Boolean.Parse(text),
            TypeCode.Char => (T) (object) Char.Parse(text),
            TypeCode.SByte => (T) (object) SByte.Parse(text),
            TypeCode.Byte => (T) (object) Byte.Parse(text),
            TypeCode.Int16 => (T) (object) Int16.Parse(text),
            TypeCode.UInt16 => (T) (object) UInt16.Parse(text),
            TypeCode.Int32 => (T) (object) Int32.Parse(text),
            TypeCode.UInt32 => (T) (object) UInt32.Parse(text),
            TypeCode.Int64 => (T) (object) Int64.Parse(text),
            TypeCode.UInt64 => (T) (object) UInt64.Parse(text),
            TypeCode.Single => (T) (object) Single.Parse(text),
            TypeCode.Double => (T) (object) Double.Parse(text),
            TypeCode.Decimal => (T) (object) Decimal.Parse(text),
            TypeCode.DateTime => (T) (object) DateTime.Parse(text),
            TypeCode.String => (T) (object) text,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}