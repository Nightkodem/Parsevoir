using Parsevoir.Converters;
using Parsevoir.Utils;

namespace Parsevoir;

public static partial class Parse
{
    public static T Single<T>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T : IConvertible
    {
        const int results = 1;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T value = CustomConverter.Convert<T>(splits[0]);
        return value;
    }
    
    public static (T0, T1) Single<T0, T1>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
    {
        const int results = 2;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        return (val0, val1);
    }
    
    public static (T0, T1, T2) Single<T0, T1, T2>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
    {
        const int results = 3;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        return (val0, val1, val2);
    }
    
    public static (T0, T1, T2, T3) Single<T0, T1, T2, T3>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
    {
        const int results = 4;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        T3 val3 = CustomConverter.Convert<T3>(splits[3]);
        return (val0, val1, val2, val3);
    }
    
    public static (T0, T1, T2, T3, T4) Single<T0, T1, T2, T3, T4>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
    {
        const int results = 5;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        T3 val3 = CustomConverter.Convert<T3>(splits[3]);
        T4 val4 = CustomConverter.Convert<T4>(splits[4]);
        return (val0, val1, val2, val3, val4);
    }
    
    public static (T0, T1, T2, T3, T4, T5) Single<T0, T1, T2, T3, T4, T5>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
    {
        const int results = 6;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        T3 val3 = CustomConverter.Convert<T3>(splits[3]);
        T4 val4 = CustomConverter.Convert<T4>(splits[4]);
        T5 val5 = CustomConverter.Convert<T5>(splits[5]);
        return (val0, val1, val2, val3, val4, val5);
    }
    
    public static (T0, T1, T2, T3, T4, T5, T6) Single<T0, T1, T2, T3, T4, T5, T6>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
    {
        const int results = 7;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        T3 val3 = CustomConverter.Convert<T3>(splits[3]);
        T4 val4 = CustomConverter.Convert<T4>(splits[4]);
        T5 val5 = CustomConverter.Convert<T5>(splits[5]);
        T6 val6 = CustomConverter.Convert<T6>(splits[6]);
        return (val0, val1, val2, val3, val4, val5, val6);
    }
    
    public static (T0, T1, T2, T3, T4, T5, T6, T7) Single<T0, T1, T2, T3, T4, T5, T6, T7>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
        where T7 : IConvertible
    {
        const int results = 8;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        T3 val3 = CustomConverter.Convert<T3>(splits[3]);
        T4 val4 = CustomConverter.Convert<T4>(splits[4]);
        T5 val5 = CustomConverter.Convert<T5>(splits[5]);
        T6 val6 = CustomConverter.Convert<T6>(splits[6]);
        T7 val7 = CustomConverter.Convert<T7>(splits[7]);
        return (val0, val1, val2, val3, val4, val5, val6, val7);
    }
    
    public static (T0, T1, T2, T3, T4, T5, T6, T7, T8) Single<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
        where T7 : IConvertible
        where T8 : IConvertible
    {
        const int results = 9;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        T3 val3 = CustomConverter.Convert<T3>(splits[3]);
        T4 val4 = CustomConverter.Convert<T4>(splits[4]);
        T5 val5 = CustomConverter.Convert<T5>(splits[5]);
        T6 val6 = CustomConverter.Convert<T6>(splits[6]);
        T7 val7 = CustomConverter.Convert<T7>(splits[7]);
        T8 val8 = CustomConverter.Convert<T8>(splits[8]);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8);
    }
    
    public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) Single<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
        where T7 : IConvertible
        where T8 : IConvertible
        where T9 : IConvertible
    {
        const int results = 10;

        string[] splits = StringSplitter.Split(source, template, results, bracketsCount, options);

        T0 val0 = CustomConverter.Convert<T0>(splits[0]);
        T1 val1 = CustomConverter.Convert<T1>(splits[1]);
        T2 val2 = CustomConverter.Convert<T2>(splits[2]);
        T3 val3 = CustomConverter.Convert<T3>(splits[3]);
        T4 val4 = CustomConverter.Convert<T4>(splits[4]);
        T5 val5 = CustomConverter.Convert<T5>(splits[5]);
        T6 val6 = CustomConverter.Convert<T6>(splits[6]);
        T7 val7 = CustomConverter.Convert<T7>(splits[7]);
        T8 val8 = CustomConverter.Convert<T8>(splits[8]);
        T9 val9 = CustomConverter.Convert<T9>(splits[9]);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8, val9);
    }
}