using System.Text.Json;

public class StringJsonRepository : IStringRepository
{
    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<string>>(fileContent);
        }
        return new List<string>();
    }

    public void Write(string filePath, List<string> content)
    {
        File.WriteAllText(filePath, JsonSerializer.Serialize(content));
    }
}