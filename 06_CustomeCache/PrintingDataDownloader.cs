using System.Diagnostics;

public class PrintingDataDownloader : IDataDownloader
{
    private IDataDownloader _dataDownloader;

    public PrintingDataDownloader(IDataDownloader dataDownloader)
    {
        _dataDownloader = dataDownloader;
    }

    public string Download(string key)
    {

        Stopwatch sw = Stopwatch.StartNew();

        string data = _dataDownloader.Download(key);

        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Data retrieved");
        Console.WriteLine($"operation took {sw.ElapsedMilliseconds} Milliseconds");
        Console.ForegroundColor = previousColor;
        
        return data;
    }
}