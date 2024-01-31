public class ConsoleUserInteraction : IUserInteraction
{
    public string ReadValidFileName()
    {
        bool isFileNameValid = false;
        string fileName;
        do
        {
            PrintMessage("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                PrintMessage("The file name cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                PrintMessage("The file name cannot be empty.");
            }
            else if (!File.Exists(fileName))
            {
                PrintMessage("The file does not exist.");
            }
            else
            {
                isFileNameValid = true;
            }

        } while (!isFileNameValid);
        return fileName;
    }

    public void PrintError(string message)
    {
        var orginalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        PrintMessage(message);
        Console.ForegroundColor = orginalColor;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

}