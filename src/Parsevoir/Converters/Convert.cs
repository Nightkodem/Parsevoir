namespace Parsevoir.Converters;

internal static class Convert
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
        { typeof(string), TypeCode.String },
    };

    internal static T To<T>(string text)
    {
        object value = ToObjectOf<T>(text);
        return (T)value;
    }

    internal static object ToObjectOf<T>(string text)
    {
        TypeCode typeCode = TypeCodes[typeof(T)];

        return typeCode switch
        {
            TypeCode.Boolean => Boolean.Parse(text),
            TypeCode.Char => Char.Parse(text),
            TypeCode.SByte => SByte.Parse(text),
            TypeCode.Byte => Byte.Parse(text),
            TypeCode.Int16 => Int16.Parse(text),
            TypeCode.UInt16 => UInt16.Parse(text),
            TypeCode.Int32 => Int32.Parse(text),
            TypeCode.UInt32 => UInt32.Parse(text),
            TypeCode.Int64 => Int64.Parse(text),
            TypeCode.UInt64 => UInt64.Parse(text),
            TypeCode.Single => Single.Parse(text),
            TypeCode.Double => Double.Parse(text),
            TypeCode.Decimal => Decimal.Parse(text),
            TypeCode.DateTime => DateTime.Parse(text),
            TypeCode.String => text,
            _ => throw new ArgumentOutOfRangeException(nameof(typeCode), $"Invalid type passed! Type: {typeof(T).FullName}")
        };
    }
}