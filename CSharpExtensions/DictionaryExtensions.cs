using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lemao.UtilExtensions;

public static class DictionaryExtensions
{
    public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value) where TKey : notnull
    {
        ref var dictionaryValue = ref CollectionsMarshal.GetValueRefOrAddDefault(dict, key, out var exists);
        if (exists && dictionaryValue is not null)
        {
            return dictionaryValue;
        }

        dictionaryValue = value;

        return value;
    }

    public static bool TryUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value) where TKey : notnull
    {
        ref var dictionaryValue = ref CollectionsMarshal.GetValueRefOrNullRef(dict, key);
        if (Unsafe.IsNullRef(ref dictionaryValue))
        {
            return false;
        }

        dictionaryValue = value;

        return true;
    }
}
