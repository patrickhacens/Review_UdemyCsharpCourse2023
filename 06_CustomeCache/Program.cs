

ICache<string, string> filesCache = new Cache<string, string>();


IDataDownloader dataDownloader = new LocalFileDataDownloader();

IDataDownloader cachingDataDownloader =
    new CachingDataDownloader(dataDownloader, filesCache);


Console.WriteLine(cachingDataDownloader.Download("a.txt"));
Console.WriteLine(cachingDataDownloader.Download("b.txt"));
Console.WriteLine(cachingDataDownloader.Download("a.txt"));
Console.WriteLine(cachingDataDownloader.Download("b.txt"));


ICache<string, string> apisRequestsCache = new Cache<string, string>();

IDataDownloader apiDownloader = new APIDataDownloader();

IDataDownloader cachingApiDataDownloader = new CachingDataDownloader(apiDownloader, apisRequestsCache);
Console.WriteLine(
    apiDownloader.Download("https://en.wikipedia.org/wiki/Unified_Modeling_Language"));

Console.WriteLine(
    apiDownloader.Download("https://en.wikipedia.org/wiki/Unified_Modeling_Language"));



Console.ReadKey();