using GameDataParser.Model;

namespace GameDataParser.UserInteraction;

public interface IUserInteraction
{
    void Exit();
    string ReadFileNameFromUser();
    void ShowMessage(string message);
    void ShowError(string message);
    void PrintGameDatas(List<GameData> gameDatas);
}