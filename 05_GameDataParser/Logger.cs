using System.Text;

public class Logger
{
    private string _logFileName;

    public Logger(string logFileName)
    {
        _logFileName = logFileName;
    }

    public void Log(Exception ex)
    {
        var message = new StringBuilder();
        message.AppendLine($"[{DateTime.Now}]");
        message.AppendLine($"Exception message: {ex.Message}");
        message.AppendLine($"Stack trace: {ex.StackTrace}");
        message.AppendLine($"{Environment.NewLine}");


        File.AppendAllText(_logFileName, message.ToString());
    }
}