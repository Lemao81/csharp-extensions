using System.Diagnostics.CodeAnalysis;

namespace Lemao.UtilExtensions;

public static class StringExtensions
{
    public static bool IsNull([NotNullWhen(returnValue: false)] this string? str) => str is null;

    public static bool IsEmpty(this string? str) => str == string.Empty;

    public static bool IsNullOrEmpty([NotNullWhen(returnValue: false)] this string? str) => string.IsNullOrEmpty(str);

    public static bool IsNullOrWhiteSpace([NotNullWhen(returnValue: false)] this string? str) => string.IsNullOrWhiteSpace(str);
}
