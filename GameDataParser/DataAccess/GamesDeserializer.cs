using GameDataParser.Model;
using GameDataParser.UserInteraction;
using System.Text.Json;

namespace GameDataParser.DataAccess;

public class GamesDeserializer : IGamesDeserializer
{
    private readonly IUserInteraction _userInteraction;
    public GamesDeserializer(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public List<GameData> DeserializeGameData(
        string fileContents,
        string fileName)
    {
        try
        {
            return JsonSerializer.Deserialize<List<GameData>>(fileContents);
        }
        catch (JsonException ex)
        {
            _userInteraction.ShowError($"JSON in the {fileName} was not in a valid format. JSON body:");
            _userInteraction.ShowError(fileContents);
            throw new JsonException(ex.Message);
        }
    }
}