using Parsevoir.Utils;

namespace Parsevoir.Converters;

internal static class SplitsConverter
{
    internal static T ToResults<T>(IReadOnlyList<SplitResult> splits)
        where T : IConvertible
    {
        T val = Convert.To<T>(splits[0].Value);
        return val;
    }
    
    internal static (T0, T1) ToResults<T0, T1>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        return (val0, val1);
    }

    internal static (T0, T1, T2) ToResults<T0, T1, T2>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        return (val0, val1, val2);
    }

    internal static (T0, T1, T2, T3) ToResults<T0, T1, T2, T3>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        T3 val3 = Convert.To<T3>(splits[3].Value);
        return (val0, val1, val2, val3);
    }

    internal static (T0, T1, T2, T3, T4) ToResults<T0, T1, T2, T3, T4>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        T3 val3 = Convert.To<T3>(splits[3].Value);
        T4 val4 = Convert.To<T4>(splits[4].Value);
        return (val0, val1, val2, val3, val4);
    }

    internal static (T0, T1, T2, T3, T4, T5) ToResults<T0, T1, T2, T3, T4, T5>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        T3 val3 = Convert.To<T3>(splits[3].Value);
        T4 val4 = Convert.To<T4>(splits[4].Value);
        T5 val5 = Convert.To<T5>(splits[5].Value);
        return (val0, val1, val2, val3, val4, val5);
    }
    
    internal static (T0, T1, T2, T3, T4, T5, T6) ToResults<T0, T1, T2, T3, T4, T5, T6>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        T3 val3 = Convert.To<T3>(splits[3].Value);
        T4 val4 = Convert.To<T4>(splits[4].Value);
        T5 val5 = Convert.To<T5>(splits[5].Value);
        T6 val6 = Convert.To<T6>(splits[6].Value);
        return (val0, val1, val2, val3, val4, val5, val6);
    }
    
    internal static (T0, T1, T2, T3, T4, T5, T6, T7) ToResults<T0, T1, T2, T3, T4, T5, T6, T7>(IReadOnlyList<SplitResult> splits)
        where T0 : IConvertible
        where T1 : IConvertible
        where T2 : IConvertible
        where T3 : IConvertible
        where T4 : IConvertible
        where T5 : IConvertible
        where T6 : IConvertible
        where T7 : IConvertible
    {
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        T3 val3 = Convert.To<T3>(splits[3].Value);
        T4 val4 = Convert.To<T4>(splits[4].Value);
        T5 val5 = Convert.To<T5>(splits[5].Value);
        T6 val6 = Convert.To<T6>(splits[6].Value);
        T7 val7 = Convert.To<T7>(splits[7].Value);
        return (val0, val1, val2, val3, val4, val5, val6, val7);
    }
    
    internal static (T0, T1, T2, T3, T4, T5, T6, T7, T8) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8>(IReadOnlyList<SplitResult> splits)
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
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        T3 val3 = Convert.To<T3>(splits[3].Value);
        T4 val4 = Convert.To<T4>(splits[4].Value);
        T5 val5 = Convert.To<T5>(splits[5].Value);
        T6 val6 = Convert.To<T6>(splits[6].Value);
        T7 val7 = Convert.To<T7>(splits[7].Value);
        T8 val8 = Convert.To<T8>(splits[8].Value);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8);
    }
    
    internal static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(IReadOnlyList<SplitResult> splits)
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
        T0 val0 = Convert.To<T0>(splits[0].Value);
        T1 val1 = Convert.To<T1>(splits[1].Value);
        T2 val2 = Convert.To<T2>(splits[2].Value);
        T3 val3 = Convert.To<T3>(splits[3].Value);
        T4 val4 = Convert.To<T4>(splits[4].Value);
        T5 val5 = Convert.To<T5>(splits[5].Value);
        T6 val6 = Convert.To<T6>(splits[6].Value);
        T7 val7 = Convert.To<T7>(splits[7].Value);
        T8 val8 = Convert.To<T8>(splits[8].Value);
        T9 val9 = Convert.To<T9>(splits[9].Value);
        return (val0, val1, val2, val3, val4, val5, val6, val7, val8, val9);
    }
}