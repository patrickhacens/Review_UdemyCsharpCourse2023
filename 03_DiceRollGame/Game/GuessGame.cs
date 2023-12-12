
using DiceRollGame.UserComunication;

namespace DiceRollGame.Game;
public class GuessGame
{
    private Dice _dice;
    private int _tries;


    public GuessGame(Dice dice, int tries = 3)
    {
        _dice = dice;
        _tries = tries;
    }

    public GameResult Play()
    {
        int diceValue = _dice.Roll();
        int tries = _tries;

        Console.WriteLine($"Dice rolled. Guess what number it shows in {_tries} tries.");
        while (tries > 0)
        {
            int guessedNumber = ConsoleReader.ReadInteger("Enter a number:");
            if (guessedNumber == diceValue)
            {
                return GameResult.Victroy;
            }
            else
            {
                Console.WriteLine("Wrong number.");
            }
            tries--;
        }
        return GameResult.Lose;
    }

    public static void PrintResults(GameResult gameResult)
    {
        string message = gameResult == GameResult.Victroy ? "You win :)" : "You lose :(";
        Console.WriteLine(message);
    }

    public enum GameResult
    {
        Lose,
        Victroy
    }
}
