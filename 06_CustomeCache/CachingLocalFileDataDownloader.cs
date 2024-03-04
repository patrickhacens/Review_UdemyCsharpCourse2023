internal class CachingLocalFileDataDownloader : IDataDownloader<string, string>
{
    private IDataDownloader<string, string> _dataDownloader;
    private ICache<string, string> _filesCache;

    public CachingLocalFileDataDownloader(IDataDownloader<string, string> dataDownloader, ICache<string, string> filesCache)
    {
        _dataDownloader = dataDownloader;
        _filesCache = filesCache;
    }

    public string Download(string key) =>
        _filesCache.Get(key, _dataDownloader.Download);

}