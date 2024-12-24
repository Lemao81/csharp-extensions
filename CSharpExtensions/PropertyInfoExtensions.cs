using System.Reflection;

namespace UtilExtensions;

public static class PropertyInfoExtensions
{
    public static bool IsEnum(this PropertyInfo? property) => property?.PropertyType is { IsEnum: true };

    public static bool IsEnumerableOf(this PropertyInfo? property, Type elementType)
    {
        ArgumentNullException.ThrowIfNull(property);

        return typeof(IEnumerable<>).MakeGenericType(elementType).IsAssignableFrom(property.PropertyType);
    }

    public static bool HasAttribute<T>(this PropertyInfo? property) where T : Attribute => property?.GetCustomAttribute<T>() is not null;

    public static bool TryGetCustomAttribute<T>(this PropertyInfo? property, out T? attribute) where T : Attribute
    {
        attribute = null;
        if (property is null)
        {
            return false;
        }

        attribute = property.GetCustomAttribute<T>();

        return attribute is not null;
    }
}
