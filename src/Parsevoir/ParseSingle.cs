using Parsevoir.Converters;
using Parsevoir.Utils;

namespace Parsevoir;

public static partial class Parse
{
    public static T Single<T>(string source, string template, int bracketsCount = 1, ParsingOptions? options = null)
        where T : IConvertible
    {
        const int results = 1;

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount, options);
        var splits = stringSplitter.Split();


        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T>(splits);
    }

    public static (T0, T1) Single<T0, T1>(string source, string template, int bracketsCount = 1,
        ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
    {
        const int results = 2;

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1>(splits);
    }

    public static (T0, T1, T2) Single<T0, T1, T2>(string source, string template, int bracketsCount = 1,
        ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
    {
        const int results = 3;

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();
        
        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2>(splits);
    }

    public static (T0, T1, T2, T3) Single<T0, T1, T2, T3>(string source, string template, int bracketsCount = 1,
        ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
    {
        const int results = 4;

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2, T3>(splits);
    }

    public static (T0, T1, T2, T3, T4) Single<T0, T1, T2, T3, T4>(string source, string template, int bracketsCount = 1,
        ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
    {
        const int results = 5;

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2, T3, T4>(splits);
    }

    public static (T0, T1, T2, T3, T4, T5) Single<T0, T1, T2, T3, T4, T5>(string source, string template,
        int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
    {
        const int results = 6;

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2, T3, T4, T5>(splits);
    }

    public static (T0, T1, T2, T3, T4, T5, T6) Single<T0, T1, T2, T3, T4, T5, T6>(string source, string template,
        int bracketsCount = 1, ParsingOptions? options = null)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
    {
        const int results = 7;

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2, T3, T4, T5, T6>(splits);
    }

    public static (T0, T1, T2, T3, T4, T5, T6, T7) Single<T0, T1, T2, T3, T4, T5, T6, T7>(string source,
        string template, int bracketsCount = 1, ParsingOptions? options = null)
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

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2, T3, T4, T5, T6, T7>(splits);
    }

    public static (T0, T1, T2, T3, T4, T5, T6, T7, T8) Single<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string source,
        string template, int bracketsCount = 1, ParsingOptions? options = null)
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

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8>(splits);
    }

    public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) Single<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string source,
        string template, int bracketsCount = 1, ParsingOptions? options = null)
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

        var stringSplitter = new StringSplitter(source, template, results, bracketsCount);
        var splits = stringSplitter.Split();

        var splitsConverter = new SplitsConverter(options);
        return splitsConverter.ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(splits);
    }
}