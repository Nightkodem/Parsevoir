#nullable enable

using System;
using System.Collections.Generic;

namespace Parsevoir.Converters;

internal class ManySplitsConverter
{
    private readonly Convert _convert;

    public ManySplitsConverter(ParsingOptions? options)
    {
        _convert = new Convert(options ?? ParsingOptions.DefaultParsingOptions);
    }

    internal T[] ToResults<T>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T[] values = _convert.To<T>(typesToSplits, 0);
        return values;
    }

#if NETSTANDARD2_0 || NETSTANDARD2_1
    
    internal Tuple<T0[], T1[]> ToResults<T0, T1>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        return new Tuple<T0[], T1[]>(values0, values1);
    }

    internal Tuple<T0[], T1[], T2[]> ToResults<T0, T1, T2>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        return new Tuple<T0[], T1[], T2[]>(values0, values1, values2);
    }

    internal Tuple<T0[], T1[], T2[], T3[]> ToResults<T0, T1, T2, T3>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        return new Tuple<T0[], T1[], T2[], T3[]>(values0, values1, values2, values3);
    }

    internal Tuple<T0[], T1[], T2[], T3[], T4[]> ToResults<T0, T1, T2, T3, T4>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        return new Tuple<T0[], T1[], T2[], T3[], T4[]>(values0, values1, values2, values3, values4);
    }

    internal Tuple<T0[], T1[], T2[], T3[], T4[], T5[]> ToResults<T0, T1, T2, T3, T4, T5>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        T5[] values5 = _convert.To<T5>(typesToSplits, 5);
        return new Tuple<T0[], T1[], T2[], T3[], T4[], T5[]>(values0, values1, values2, values3, values4, values5);
    }

    internal Tuple<T0[], T1[], T2[], T3[], T4[], T5[], T6[]> ToResults<T0, T1, T2, T3, T4, T5, T6>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        T5[] values5 = _convert.To<T5>(typesToSplits, 5);
        T6[] values6 = _convert.To<T6>(typesToSplits, 6);
        return new Tuple<T0[], T1[], T2[], T3[], T4[], T5[], T6[]>(values0, values1, values2, values3, values4, values5, values6);
    }

#else
    
    internal (T0[], T1[]) ToResults<T0, T1>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        return (values0, values1);
    }

    internal (T0[], T1[], T2[]) ToResults<T0, T1, T2>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        return (values0, values1, values2);
    }

    internal (T0[], T1[], T2[], T3[]) ToResults<T0, T1, T2, T3>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        return (values0, values1, values2, values3);
    }

    internal (T0[], T1[], T2[], T3[], T4[]) ToResults<T0, T1, T2, T3, T4>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        return (values0, values1, values2, values3, values4);
    }

    internal (T0[], T1[], T2[], T3[], T4[], T5[]) ToResults<T0, T1, T2, T3, T4, T5>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        T5[] values5 = _convert.To<T5>(typesToSplits, 5);
        return (values0, values1, values2, values3, values4, values5);
    }

    internal (T0[], T1[], T2[], T3[], T4[], T5[], T6[]) ToResults<T0, T1, T2, T3, T4, T5, T6>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        T5[] values5 = _convert.To<T5>(typesToSplits, 5);
        T6[] values6 = _convert.To<T6>(typesToSplits, 6);
        return (values0, values1, values2, values3, values4, values5, values6);
    }

    internal (T0[], T1[], T2[], T3[], T4[], T5[], T6[], T7[]) ToResults<T0, T1, T2, T3, T4, T5, T6, T7>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        T5[] values5 = _convert.To<T5>(typesToSplits, 5);
        T6[] values6 = _convert.To<T6>(typesToSplits, 6);
        T7[] values7 = _convert.To<T7>(typesToSplits, 7);
        return (values0, values1, values2, values3, values4, values5, values6, values7);
    }

    internal (T0[], T1[], T2[], T3[], T4[], T5[], T6[], T7[], T8[]) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        T5[] values5 = _convert.To<T5>(typesToSplits, 5);
        T6[] values6 = _convert.To<T6>(typesToSplits, 6);
        T7[] values7 = _convert.To<T7>(typesToSplits, 7);
        T8[] values8 = _convert.To<T8>(typesToSplits, 8);
        return (values0, values1, values2, values3, values4, values5, values6, values7, values8);
    }

    internal (T0[], T1[], T2[], T3[], T4[], T5[], T6[], T7[], T8[], T9[]) ToResults<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(IReadOnlyDictionary<int, string[]> typesToSplits)
    {
        T0[] values0 = _convert.To<T0>(typesToSplits, 0);
        T1[] values1 = _convert.To<T1>(typesToSplits, 1);
        T2[] values2 = _convert.To<T2>(typesToSplits, 2);
        T3[] values3 = _convert.To<T3>(typesToSplits, 3);
        T4[] values4 = _convert.To<T4>(typesToSplits, 4);
        T5[] values5 = _convert.To<T5>(typesToSplits, 5);
        T6[] values6 = _convert.To<T6>(typesToSplits, 6);
        T7[] values7 = _convert.To<T7>(typesToSplits, 7);
        T8[] values8 = _convert.To<T8>(typesToSplits, 8);
        T9[] values9 = _convert.To<T9>(typesToSplits, 9);
        return (values0, values1, values2, values3, values4, values5, values6, values7, values8, values9);
    }
#endif
}