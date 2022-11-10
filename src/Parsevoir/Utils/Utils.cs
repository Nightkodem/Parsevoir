using System.Text;

namespace Parsevoir.Utils;

internal static class Brackets
{
    private const char OpenChar = '{';
    private const char CloseChar = '}';
    
    internal static (string open, string close) GetOpenAndCloseString(int bracketsCount)
    {
        if (bracketsCount < 1) throw new ArgumentException("Value must be larger than 0!", nameof(bracketsCount));

        switch (bracketsCount)
        {
            case <= 0:
                throw new ArgumentException("Value must be larger than 0!", nameof(bracketsCount));
            case 1:
                return ($"{OpenChar}", $"{CloseChar}");
            case 2:
                return ($"{OpenChar}{OpenChar}", $"{CloseChar}{CloseChar}");
            case 3:
                return ($"{OpenChar}{OpenChar}{OpenChar}", $"{CloseChar}{CloseChar}{CloseChar}");
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