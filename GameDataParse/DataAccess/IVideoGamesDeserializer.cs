using GameDataParse.Model;

namespace GameDataParse.DataAccess
{
    public interface IVideoGamesDeserializer
    {
        List<VideoGame> DeserializeFrom(string fileName, string fileContents);
    }
}
