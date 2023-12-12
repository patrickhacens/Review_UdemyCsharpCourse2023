
namespace DiceRollGame.Game;

public class Dice
{
    private Random _random;
    private const int DiceSides = 6;
    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, DiceSides + 1);
    public void Describe() => Console.WriteLine($"This dice have {DiceSides} sides");

}