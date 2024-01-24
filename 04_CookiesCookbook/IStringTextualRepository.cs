public interface IStringTextualRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, List<string> content);
}