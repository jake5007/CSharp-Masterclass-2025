using GameDataParser.Model;
using GameDataParser.DataAccess;

namespace GameDataParser.UserInteraction;

public class ConsoleUserInteraction : IUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public string ReadFileNameFromUser()
    {
        while (true)
        {
            ShowMessage("Enter the name of the file you want to read:");
            var userInput = Console.ReadLine();

            if (userInput is null)
            {
                ShowMessage("File name cannot be null.");
                continue;
            }
            else if (string.IsNullOrWhiteSpace(userInput))
            {
                ShowMessage("File name cannot be empty.");
                continue;
            }
            else if (!File.Exists(AppPaths.LocalJsonPath + userInput))
            {
                ShowMessage("File not found");
                continue;
            }
            return userInput;
        }
    }

    public void PrintGameDatas(List<GameData> gameDatas)
    {
        if (gameDatas.Count > 0)
        {
            ShowMessage(Environment.NewLine + "Loaded games are:");
            foreach (var gameData in gameDatas)
            {
                ShowMessage(gameData.ToString());
            }
            return;
        }

        ShowMessage("No games are present in the input file.");
    }
}