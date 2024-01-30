using System.Text.Json;

bool isFileRead = false;
string fileContent = "";

do
{
    try
    {
        Console.WriteLine("Enter the name of the file you want to read:");
        string fileName = Console.ReadLine();
        fileContent = File.ReadAllText(Path.Combine("Resources", fileName));
        isFileRead = true;
    }

    catch (FileNotFoundException ex)
    {
        Console.WriteLine("The file does not exist.");
    }
    catch (UnauthorizedAccessException ex)
    {
        Console.WriteLine("The file does not exist.");
    }

    catch (ArgumentNullException ex)
    {
        Console.WriteLine("The file name cannot be null.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("The file name cannot be empty.");
    }




} while (!isFileRead);
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
