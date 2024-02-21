using System.Net;

public class APIDataDownloader : IDataDownloader<string, string>
{
    private ICache<string, string> _apisRequestsCache;

    public APIDataDownloader(ICache<string, string> apisRequestsCache)
    {
        _apisRequestsCache = apisRequestsCache;
    }

    public string Download(string address)
    {
        Func<string, string> func = (address) =>
        {
            using WebClient webClient = new WebClient();
            using Stream stream = webClient.OpenRead(address);
            using StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();

        };

        return _apisRequestsCache.Get(address, func);
    }
}