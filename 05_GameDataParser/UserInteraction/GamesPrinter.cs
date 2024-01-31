public class GamesPrinter : IGamesPrinter
{
    private readonly IUserInteraction _userInteraction;

    public GamesPrinter(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public void Print(IEnumerable<VideoGame> games)
    {
        if (games.Count() > 0)
        {
            _userInteraction.PrintMessage($"{Environment.NewLine}Loaded games are:");
            foreach (VideoGame game in games)
            {
                _userInteraction.PrintMessage(game.ToString());
            }
        }
        else
        {
            _userInteraction.PrintMessage("No games are present in the input file.");
        }
    }
}
