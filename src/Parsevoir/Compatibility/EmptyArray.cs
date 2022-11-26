using System;

namespace Parsevoir.Compatibility
{
    public static class EmptyArray
    {
#if NET452
        
        public static T[] Value<T>() => EmptyArrays<T>.Value;
        
        private static class EmptyArrays<T>
        {
            internal static readonly T[] Value = new T[0];
        }
        
#else
        
        public static T[] Value<T>() =>  Array.Empty<T>();

#endif
    }
}