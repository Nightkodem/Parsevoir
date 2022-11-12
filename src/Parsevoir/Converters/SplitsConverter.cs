using Parsevoir.Utils;

namespace Parsevoir.Converters;

internal class SplitsConverter
{
    private readonly ParsingOptions _options;

    public SplitsConverter(ParsingOptions? options)
    {
        _options = options ?? ParsingOptions.DefaultParsingOptions;
    }

    internal T ToResults<T>(IReadOnlyList<SplitResult> splits)
        where T : IConvertible
    {
        T val = Convert.To<T>(splits[0].Value, _options);
        return val;
    }
    
    internal (T0, T1) ToResults<T0, T1>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        return (val0, val1);
    }

    internal (T0, T1, T2) ToResults<T0, T1, T2>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        return (val0, val1, val2);
    }

    internal (T0, T1, T2, T3) ToResults<T0, T1, T2, T3>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        T3 val3 = Convert.To<T3>(splits[3].Value, _options);
        return (val0, val1, val2, val3);
    }

    internal (T0, T1, T2, T3, T4) ToResults<T0, T1, T2, T3, T4>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        T3 val3 = Convert.To<T3>(splits[3].Value, _options);
        T4 val4 = Convert.To<T4>(splits[4].Value, _options);
        return (val0, val1, val2, val3, val4);
    }

    internal (T0, T1, T2, T3, T4, T5) ToResults<T0, T1, T2, T3, T4, T5>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        T3 val3 = Convert.To<T3>(splits[3].Value, _options);
        T4 val4 = Convert.To<T4>(splits[4].Value, _options);
        T5 val5 = Convert.To<T5>(splits[5].Value, _options);
        return (val0, val1, val2, val3, val4, val5);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6) ToResults<T0, T1, T2, T3, T4, T5, T6>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        T3 val3 = Convert.To<T3>(splits[3].Value, _options);
        T4 val4 = Convert.To<T4>(splits[4].Value, _options);
        T5 val5 = Convert.To<T5>(splits[5].Value, _options);
        T6 val6 = Convert.To<T6>(splits[6].Value, _options);
        return (val0, val1, val2, val3, val4, val5, val6);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6, T7) ToResults<T0, T1, T2, T3, T4, T5, T6, T7>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
        where T7 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        T3 val3 = Convert.To<T3>(splits[3].Value, _options);
        T4 val4 = Convert.To<T4>(splits[4].Value, _options);
        T5 val5 = Convert.To<T5>(splits[5].Value, _options);
        T6 val6 = Convert.To<T6>(splits[6].Value, _options);
        T7 val7 = Convert.To<T7>(splits[7].Value, _options);
        return (val0, val1, val2, val3, val4, val5, val6, val7);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6, T7, T8) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8>(IReadOnlyList<SplitResult> splits)
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
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        T3 val3 = Convert.To<T3>(splits[3].Value, _options);
        T4 val4 = Convert.To<T4>(splits[4].Value, _options);
        T5 val5 = Convert.To<T5>(splits[5].Value, _options);
        T6 val6 = Convert.To<T6>(splits[6].Value, _options);
        T7 val7 = Convert.To<T7>(splits[7].Value, _options);
        T8 val8 = Convert.To<T8>(splits[8].Value, _options);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(IReadOnlyList<SplitResult> splits)
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
        T0 val0 = Convert.To<T0>(splits[0].Value, _options);
        T1 val1 = Convert.To<T1>(splits[1].Value, _options);
        T2 val2 = Convert.To<T2>(splits[2].Value, _options);
        T3 val3 = Convert.To<T3>(splits[3].Value, _options);
        T4 val4 = Convert.To<T4>(splits[4].Value, _options);
        T5 val5 = Convert.To<T5>(splits[5].Value, _options);
        T6 val6 = Convert.To<T6>(splits[6].Value, _options);
        T7 val7 = Convert.To<T7>(splits[7].Value, _options);
        T8 val8 = Convert.To<T8>(splits[8].Value, _options);
        T9 val9 = Convert.To<T9>(splits[9].Value, _options);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8, val9);
    }
}