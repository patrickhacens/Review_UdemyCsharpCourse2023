
IUserInteraction userInteraction = new ConsoleUserInteraction();
IGamesPrinter gamesPrinter = new GamesPrinter(userInteraction);
IVideoGamesDeserializer videoGamesDeserializer = new VideoGamesDeserializer(userInteraction);
IFileReader fileReader = new LocalFileReader();

var app = new GameDataParserApp(userInteraction, gamesPrinter
    , videoGamesDeserializer, fileReader);
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    userInteraction.PrintMessage("Sorry! the application has experienced an unexpected error" +
        "and will have to be closed.");
    logger.Log(ex);
}
userInteraction.PrintMessage("press any key to close.");
Console.ReadKey();
