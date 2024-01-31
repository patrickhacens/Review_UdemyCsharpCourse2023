public interface IUserInteraction
{
    public string ReadValidFileName();
    public void PrintMessage(string message);
    void PrintError(string message);
}