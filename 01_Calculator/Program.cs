Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
string operation = Console.ReadLine();
operation = operation.ToUpper();

switch (operation)
{
    case "A":
        Console.WriteLine($"{a}+{b}={a + b}");
        break;
    case "S":
        Console.WriteLine($"{a}-{b}={a - b}");
        break;
    case "M":
        Console.WriteLine($"{a}*{b}={a * b}");
        break;
    default:
        Console.WriteLine("invalid choice!");
        Console.WriteLine("press any key to close.");
        Console.ReadLine();
        break;
}
