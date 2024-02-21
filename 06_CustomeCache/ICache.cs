public interface ICache<TKey, TData>
{
    TData Get(TKey key, Func<TKey, TData> getForFirstTime);
}