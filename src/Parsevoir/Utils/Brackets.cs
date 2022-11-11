using System.Text;

namespace Parsevoir.Utils;

internal static class Brackets
{
    private const char OpenChar = '{';
    private const char CloseChar = '}';

    private static readonly (string, string) OneBracket = ($"{OpenChar}", $"{CloseChar}");
    private static readonly (string, string) TwoBrackets = ($"{OpenChar}{OpenChar}", $"{CloseChar}{CloseChar}");
    private static readonly (string, string) ThreeBrackets = ($"{OpenChar}{OpenChar}{OpenChar}", $"{CloseChar}{CloseChar}{CloseChar}");
    
    internal static (string open, string close) GetOpenAndCloseString(int bracketsCount)
    {
        switch (bracketsCount)
        {
            case <= 0:
                throw new ArgumentException("Number of brackets must be larger than 0!", nameof(bracketsCount));
            case 1:
                return OneBracket;
            case 2:
                return TwoBrackets;
            case 3:
                return ThreeBrackets;
            default:
            {
                var sb = new StringBuilder(bracketsCount);

                string open = sb.Append(OpenChar, bracketsCount).ToString();

                sb.Clear();
                string close = sb.Append(CloseChar, bracketsCount).ToString();

                return (open, close);
            }
        }
    }
}