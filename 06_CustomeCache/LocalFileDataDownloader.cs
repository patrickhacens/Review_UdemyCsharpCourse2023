public class LocalFileDataDownloader : IDataDownloader<string, string>
{
    private readonly ICache<string, string> _cache;

    public LocalFileDataDownloader(ICache<string, string> cache)
    {
        _cache = cache;
    }

    public string Download(string key)
    {
        return _cache.Get(key,
            (key) => File.ReadAllText(Path.Combine("Resources", key)));
    }
}