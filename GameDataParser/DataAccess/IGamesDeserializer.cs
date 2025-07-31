using GameDataParser.Model;

namespace GameDataParser.DataAccess;

public interface IGamesDeserializer
{
    public List<GameData> DeserializeGameData(
        string fileContents,
        string fileName);
}