using Parsevoir.Exceptions;

#if NETSTANDARD2_0 || NET452 || NET47 || NET471 || NET472 || NET48

namespace System
{
    internal readonly struct ReadOnlySpan<T>
        where T : struct
    {
        private static readonly Type CharType = typeof(char);

        public int Length => _string.Length;
        public char this[int index] => _string[index];
        
        
        private readonly string _string;

        public ReadOnlySpan(string s)
        {
            if (typeof(T) != CharType)
                throw new WeirdException($"(Pseudo)ReadOnlySpan of wrong type {typeof(T).FullName}! It is only supposed to be a shortcut.");
            _string = s;
        }

        public static implicit operator ReadOnlySpan<T>(string s)
        {
            return new ReadOnlySpan<T>(s);
        }
        
        public static implicit operator string(ReadOnlySpan<T> span)
        {
            return span._string;
        }
    }
}

#endif