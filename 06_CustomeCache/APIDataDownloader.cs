using System.Net;

public class APIDataDownloader : IDataDownloader<string, string>
{

    public APIDataDownloader()
    {
    }

    public string Download(string address)
    {
        using WebClient webClient = new WebClient();
        using Stream stream = webClient.OpenRead(address);
        using StreamReader reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}