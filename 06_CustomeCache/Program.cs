

ICache<string, string> filesCache = new Cache<string, string>();
IDataDownloader<string, string> dataDownloader = new LocalFileDataDownloader(filesCache);


Console.WriteLine(dataDownloader.Download("a.txt"));
Console.WriteLine(dataDownloader.Download("b.txt"));
Console.WriteLine(dataDownloader.Download("a.txt"));
Console.WriteLine(dataDownloader.Download("b.txt"));


ICache<string, string> apisRequestsCache = new Cache<string, string>();

IDataDownloader<string, string> apiDownloader = new APIDataDownloader(apisRequestsCache);
Console.WriteLine(
    apiDownloader.Download("https://en.wikipedia.org/wiki/Unified_Modeling_Language"));

Console.WriteLine(
    apiDownloader.Download("https://en.wikipedia.org/wiki/Unified_Modeling_Language"));



Console.ReadKey();