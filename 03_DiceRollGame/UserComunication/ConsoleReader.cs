namespace DiceRollGame.UserComunication;
public class ConsoleReader
{
    public static int ReadInteger(string message)
    {
        int number;
        string input;
        do
        {
            Console.WriteLine(message);
            input = Console.ReadLine();
            message = $"Invalid Input. {message}";

        } while (!int.TryParse(input, out number));

        return number;

    }
}