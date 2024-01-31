public interface IVideoGamesDeserializer
{
    List<VideoGame> Deserialize(string fileName, string fileContent);
}