using System.Text.Json;


public class VideoGamesDeserializer : IVideoGamesDeserializer
{
    private readonly IUserInteraction _userInteraction;

    public VideoGamesDeserializer(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public List<VideoGame> Deserialize(string fileName, string fileContent)
    {
        List<VideoGame> videoGames;
        try
        {
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
        }
        catch (JsonException ex)
        {
            _userInteraction.PrintError($"JSON in {fileName} file was not " +
                $"in a valid format. JSON body:");
            _userInteraction.PrintError(fileContent);

            throw new JsonException($"{ex.Message} the file is :{fileName}", ex);
        }

        return videoGames;
    }
}
