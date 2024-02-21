using System.Diagnostics;

public class Cache<TKey, TData> : ICache<TKey, TData>
{
    private Dictionary<TKey, TData> _cachedData;

    public Cache()
    {
        _cachedData = new();
    }

    public TData Get(TKey key, Func<TKey, TData> getForFirstTime)
    {
        Stopwatch sw = Stopwatch.StartNew();
        if (!_cachedData.ContainsKey(key))
        {
            _cachedData[key] = getForFirstTime(key);
        }
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"operation took {sw.ElapsedMilliseconds} Milliseconds");
        Console.ForegroundColor = previousColor;
        return _cachedData[key];
    }
}