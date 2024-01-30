using System.Text.Json;

Console.WriteLine("Enter the name of the file you want to read:");
string fileName = Console.ReadLine();

string fileContent = File.ReadAllText(Path.Combine("Resources", fileName));

List<VideoGame> games = JsonSerializer.Deserialize<List<VideoGame>>(fileContent);

if (games.Count > 0)
{
    Console.WriteLine();
    Console.WriteLine("Loaded games are:");
    foreach (VideoGame game in games)
    {
        Console.WriteLine(game);
    }
}
else
{
    Console.WriteLine("No games are present in the input file.");
}

public class VideoGame
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public decimal Rating { get; set; }

    public override string ToString()
    {
        return $"{Title}, released in {ReleaseYear}, rating: {Rating}";
    }
}
