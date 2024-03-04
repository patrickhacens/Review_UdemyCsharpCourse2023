internal class CachingDataDownloader : IDataDownloader
{
    private IDataDownloader _dataDownloader;
    private ICache<string, string> _filesCache;

    public CachingDataDownloader(IDataDownloader dataDownloader, ICache<string, string> filesCache)
    {
        _dataDownloader = dataDownloader;
        _filesCache = filesCache;
    }

    public string Download(string key) =>
        _filesCache.Get(key, _dataDownloader.Download);

}