using System;
using Parsevoir.Converters;
using Parsevoir.Utils;

namespace Parsevoir;

public static partial class Parse
{
    public static T[] Many<T>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T>(splits);
    }

#if NETSTANDARD2_0 || NETSTANDARD2_1
    
    public static Tuple<T0[], T1[]> Many<T0, T1>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1>(splits);
    }
    
    public static Tuple<T0[], T1[], T2[]> Many<T0, T1, T2>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2>(splits);
    }
    
    public static Tuple<T0[], T1[], T2[], T3[]> Many<T0, T1, T2, T3>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3>(splits);
    }
    
    public static Tuple<T0[], T1[], T2[], T3[], T4[]> Many<T0, T1, T2, T3, T4>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4>(splits);
    }
    
    public static Tuple<T0[], T1[], T2[], T3[], T4[], T5[]> Many<T0, T1, T2, T3, T4, T5>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4, T5>(splits);
    }
    
    public static Tuple<T0[], T1[], T2[], T3[], T4[], T5[], T6[]> Many<T0, T1, T2, T3, T4, T5, T6>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4, T5, T6>(splits);
    }
    
#else

    public static (T0[], T1[]) Many<T0, T1>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1>(splits);
    }
    
    public static (T0[], T1[], T2[]) Many<T0, T1, T2>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2>(splits);
    }
    
    public static (T0[], T1[], T2[], T3[]) Many<T0, T1, T2, T3>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3>(splits);
    }
    
    public static (T0[], T1[], T2[], T3[], T4[]) Many<T0, T1, T2, T3, T4>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4>(splits);
    }
    
    public static (T0[], T1[], T2[], T3[], T4[], T5[]) Many<T0, T1, T2, T3, T4, T5>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4, T5>(splits);
    }
    
    public static (T0[], T1[], T2[], T3[], T4[], T5[], T6[]) Many<T0, T1, T2, T3, T4, T5, T6>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4, T5, T6>(splits);
    }
    
    public static (T0[], T1[], T2[], T3[], T4[], T5[], T6[], T7[]) Many<T0, T1, T2, T3, T4, T5, T6, T7>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
        where T7 : IConvertible
    {
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4, T5, T6, T7>(splits);
    }
    
    public static (T0[], T1[], T2[], T3[], T4[], T5[], T6[], T7[], T8[]) Many<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
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
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8>(splits);
    }
    
    public static (T0[], T1[], T2[], T3[], T4[], T5[], T6[], T7[], T8[], T9[]) Many<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
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
        var stringSplitter = new StringSplitter(source, template, -1, bracketsCount, options);
        var splits = stringSplitter.SplitMany();

        var convert = new ManySplitsConverter(options);
        return convert.ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(splits);
    }
#endif
}