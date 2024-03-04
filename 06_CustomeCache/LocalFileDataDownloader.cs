public class LocalFileDataDownloader : IDataDownloader
{

    public LocalFileDataDownloader()
    {

    }

    public string Download(string key) =>
       File.ReadAllText(Path.Combine("Resources", key));

}