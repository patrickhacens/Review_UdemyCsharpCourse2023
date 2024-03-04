public class LocalFileDataDownloader : IDataDownloader<string, string>
{

    public LocalFileDataDownloader()
    {

    }

    public string Download(string key) =>
       File.ReadAllText(Path.Combine("Resources", key));

}