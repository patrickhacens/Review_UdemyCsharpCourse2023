public abstract class StringRepository : IStringRepository
{
    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContent = File.ReadAllText(filePath);
            return TextToStrings(fileContent);
        }
        return new List<string>();
    }

    protected abstract List<string> TextToStrings(string fileContent);

    public void Write(string filePath, List<string> content)
    {
        File.WriteAllText(filePath, StringsToText(content));
    }

    protected abstract string StringsToText(List<string> content);
}