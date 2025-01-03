using System.Text;

namespace Lemao.UtilExtensions;

public static class ByteArrayExtensions
{
    public static string GetString(this byte[] bytes) => Encoding.UTF8.GetString(bytes);

    public static string ToBase64String(this byte[] bytes) => Convert.ToBase64String(bytes);
}
