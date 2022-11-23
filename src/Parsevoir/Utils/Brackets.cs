using System;
using System.Text;

namespace Parsevoir.Utils;

internal static class Brackets
{
    private const char OpenChar = '{';
    private const char CloseChar = '}';

#if NETSTANDARD2_0 || NETSTANDARD2_1
    private static readonly Tuple<string, string> OneBracket = new ($"{OpenChar}", $"{CloseChar}");
    private static readonly Tuple<string, string> TwoBrackets = new ($"{OpenChar}{OpenChar}", $"{CloseChar}{CloseChar}");
#else
    private static readonly (string, string) OneBracket = ($"{OpenChar}", $"{CloseChar}");
    private static readonly (string, string) TwoBrackets = ($"{OpenChar}{OpenChar}", $"{CloseChar}{CloseChar}");
#endif
    
#if NETSTANDARD2_0 || NETSTANDARD2_1
    internal static Tuple <string, string> GetOpenAndCloseString(int bracketsCount)
#else
    internal static (string open, string close) GetOpenAndCloseString(int bracketsCount)
#endif
    {
        switch (bracketsCount)
        {
            case <= 0:
                throw new ArgumentException("Number of brackets must be larger than 0!", nameof(bracketsCount));
            case 1:
                return OneBracket;
            case 2:
                return TwoBrackets;
            default:
            {
                string open = new string(OpenChar, bracketsCount);
                string close = new string(CloseChar, bracketsCount);

#if NETSTANDARD2_0 || NETSTANDARD2_1
                return new Tuple<string, string>(open, close);
#else
                return (open, close);
#endif
            }
        }
    }
}