using GameDataParser.App;
using GameDataParser.DataAccess;
using GameDataParser.Log;
using GameDataParser.UserInteraction;

string logFileName = AppPaths.LocalLogPath + "log.txt";

var userInteraction = new ConsoleUserInteraction();
var logger = new Logger(logFileName);
try
{
    var gameDataParserApp = new GameDataParserApp(
        userInteraction,
        new LocalFileReader(),
        new GamesDeserializer(userInteraction),
        logger);
    gameDataParserApp.Run();
}
catch (Exception ex)
{
    userInteraction.ShowMessage("Sorry! there is something wrong with this app.");
    logger.Log(ex);
    userInteraction.Exit();
}
