using System.Text.Json;

public class StringJsonRepository : StringRepository
{

    protected override string StringsToText(List<string> content) =>
        JsonSerializer.Serialize(content);

    protected override List<string> TextToStrings(string fileContent) =>
     JsonSerializer.Deserialize<List<string>>(fileContent);

}
