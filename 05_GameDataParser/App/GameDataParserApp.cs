public class GameDataParserApp
{
    private readonly IUserInteraction _userInteraction;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _fileReader;

    public GameDataParserApp(IUserInteraction userInteraction, IGamesPrinter gamesPrinter, IVideoGamesDeserializer videoGamesDeserializer, IFileReader fileReader)
    {
        _userInteraction = userInteraction;
        _gamesPrinter = gamesPrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _fileReader = fileReader;
    }

    public void Run()
    {
        string fileName = _userInteraction.ReadValidFileName();
        string fileContent = _fileReader.Read(fileName);
        List<VideoGame> videoGames = _videoGamesDeserializer.Deserialize(fileName, fileContent);
        _gamesPrinter.Print(videoGames);
    }
}
