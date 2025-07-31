namespace GameDataParser.Log;

public class Logger
{
    private readonly string _logFileName;

    public Logger(string logFileName)
    {
        _logFileName = logFileName;
    }

    public void Log(Exception ex)
    {
        try
        {
            var errorText = $"[{DateTime.Now}]\n" +
                $"Exception message: {ex.Message}\n" +
                $"Stack trace: {ex.StackTrace}\n\n";
            File.AppendAllText(_logFileName, errorText);
        }
        catch { }
    }
}