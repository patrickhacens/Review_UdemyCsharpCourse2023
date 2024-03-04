public class CachingApiDataDownloader : IDataDownloader<string, string>
{
    private IDataDownloader<string, string> _apiDownloader;
    private ICache<string, string> _apisRequestsCache;

    public CachingApiDataDownloader(IDataDownloader<string, string> apiDownloader, ICache<string, string> apisRequestsCache)
    {
        _apiDownloader = apiDownloader;
        _apisRequestsCache = apisRequestsCache;
    }

    public string Download(string key) =>
        _apisRequestsCache.Get(key, _apiDownloader.Download);

}