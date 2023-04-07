namespace NotificationCenterSdk.Extentsions;

public static class DictionaryExtensions
{
    public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T>? source)
    {
        return source ?? Enumerable.Empty<T>();
    }
}