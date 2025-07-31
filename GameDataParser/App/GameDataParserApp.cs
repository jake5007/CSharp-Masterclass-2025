using GameDataParser.DataAccess;
using GameDataParser.Log;
using GameDataParser.UserInteraction;
using System.Text.Json;

namespace GameDataParser.App;

public class GameDataParserApp
{
    private readonly IUserInteraction _userInteraction;
    private readonly IFileReader _fileReader;
    private readonly IGamesDeserializer _gamesDeserializer;
    private readonly Logger _logger;

    public GameDataParserApp(
        IUserInteraction userInteraction,
        IFileReader fileReader,
        IGamesDeserializer gamesDeserializer,
        Logger logger)
    {
        _userInteraction = userInteraction;
        _fileReader = fileReader;
        _gamesDeserializer = gamesDeserializer;
        _logger = logger;
    }

    public void Run()
    {
        try
        {
            var fileName = _userInteraction.ReadFileNameFromUser();
            var fileContents = _fileReader.Read(fileName);
            var gameDatas = _gamesDeserializer.DeserializeGameData(fileContents, fileName);
            _userInteraction.PrintGameDatas(gameDatas);
        }
        catch (JsonException ex)
        {
            _userInteraction.ShowMessage("Sorry! The application has experienced an unexpected error and will have to be closed.");
            _logger.Log(ex);
        }
        finally
        {
            _userInteraction.Exit();
        }

    }
}