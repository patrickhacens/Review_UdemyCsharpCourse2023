

ICache<string, string> filesCache = new Cache<string, string>();



IDataDownloader cachingDataDownloader =
    new PrintingDataDownloader(
        new CachingDataDownloader(new LocalFileDataDownloader(), filesCache));


Console.WriteLine(cachingDataDownloader.Download("a.txt"));
Console.WriteLine(cachingDataDownloader.Download("b.txt"));
Console.WriteLine(cachingDataDownloader.Download("a.txt"));
Console.WriteLine(cachingDataDownloader.Download("b.txt"));


ICache<string, string> apisRequestsCache = new Cache<string, string>();


IDataDownloader cachingApiDataDownloader =
    new PrintingDataDownloader(
        new CachingDataDownloader(new APIDataDownloader(), apisRequestsCache));

Console.WriteLine(
    cachingApiDataDownloader.Download("https://en.wikipedia.org/wiki/Unified_Modeling_Language"));

Console.WriteLine(
    cachingApiDataDownloader.Download("https://en.wikipedia.org/wiki/Unified_Modeling_Language"));



Console.ReadKey();