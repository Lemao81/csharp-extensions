using System.Collections.Generic;
using System.Linq;

namespace CSharpExtensions;

public static class EnumerableExtensions
{
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable) => enumerable == null || !enumerable.Any();

    public static string JoinWith(this IEnumerable<string> enumerable, string separator) => string.Join(separator, enumerable);

    public static string ToCommaSeparated(this IEnumerable<string> enumerable) => string.Join(", ", enumerable);

    public static string ToSpaceSeparated(this IEnumerable<string> enumerable) => string.Join(" ", enumerable);
}
