public class LocalFileReader : IFileReader
{
    public string Read(string fileName)
    {
        return File.ReadAllText(Path.Combine(fileName));
    }
}