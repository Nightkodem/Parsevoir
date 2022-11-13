using System.Collections.Generic;
using Parsevoir.Utils;

namespace Parsevoir.Converters;

internal class SingleSplitsConverter
{
    private readonly Convert _convert;

    public SingleSplitsConverter(ParsingOptions? options)
    {
        _convert = new Convert(options ?? ParsingOptions.DefaultParsingOptions);
    }

    internal T ToResults<T>(IReadOnlyList<string> splits)
    {
        T val = _convert.To<T>(splits[0]);
        return val;
    }
    
    internal (T0, T1) ToResults<T0, T1>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        return (val0, val1);
    }

    internal (T0, T1, T2) ToResults<T0, T1, T2>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        return (val0, val1, val2);
    }

    internal (T0, T1, T2, T3) ToResults<T0, T1, T2, T3>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        T3 val3 = _convert.To<T3>(splits[3]);
        return (val0, val1, val2, val3);
    }

    internal (T0, T1, T2, T3, T4) ToResults<T0, T1, T2, T3, T4>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        T3 val3 = _convert.To<T3>(splits[3]);
        T4 val4 = _convert.To<T4>(splits[4]);
        return (val0, val1, val2, val3, val4);
    }

    internal (T0, T1, T2, T3, T4, T5) ToResults<T0, T1, T2, T3, T4, T5>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        T3 val3 = _convert.To<T3>(splits[3]);
        T4 val4 = _convert.To<T4>(splits[4]);
        T5 val5 = _convert.To<T5>(splits[5]);
        return (val0, val1, val2, val3, val4, val5);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6) ToResults<T0, T1, T2, T3, T4, T5, T6>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        T3 val3 = _convert.To<T3>(splits[3]);
        T4 val4 = _convert.To<T4>(splits[4]);
        T5 val5 = _convert.To<T5>(splits[5]);
        T6 val6 = _convert.To<T6>(splits[6]);
        return (val0, val1, val2, val3, val4, val5, val6);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6, T7) ToResults<T0, T1, T2, T3, T4, T5, T6, T7>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        T3 val3 = _convert.To<T3>(splits[3]);
        T4 val4 = _convert.To<T4>(splits[4]);
        T5 val5 = _convert.To<T5>(splits[5]);
        T6 val6 = _convert.To<T6>(splits[6]);
        T7 val7 = _convert.To<T7>(splits[7]);
        return (val0, val1, val2, val3, val4, val5, val6, val7);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6, T7, T8) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        T3 val3 = _convert.To<T3>(splits[3]);
        T4 val4 = _convert.To<T4>(splits[4]);
        T5 val5 = _convert.To<T5>(splits[5]);
        T6 val6 = _convert.To<T6>(splits[6]);
        T7 val7 = _convert.To<T7>(splits[7]);
        T8 val8 = _convert.To<T8>(splits[8]);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8);
    }
    
    internal (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(IReadOnlyList<string> splits)
    {
        T0 val0 = _convert.To<T0>(splits[0]);
        T1 val1 = _convert.To<T1>(splits[1]);
        T2 val2 = _convert.To<T2>(splits[2]);
        T3 val3 = _convert.To<T3>(splits[3]);
        T4 val4 = _convert.To<T4>(splits[4]);
        T5 val5 = _convert.To<T5>(splits[5]);
        T6 val6 = _convert.To<T6>(splits[6]);
        T7 val7 = _convert.To<T7>(splits[7]);
        T8 val8 = _convert.To<T8>(splits[8]);
        T9 val9 = _convert.To<T9>(splits[9]);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8, val9);
    }
}