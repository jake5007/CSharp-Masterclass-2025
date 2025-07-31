namespace GameDataParser.DataAccess;

public class LocalFileReader : IFileReader
{
    public string Read(string fileName)
    {
        return File.ReadAllText(AppPaths.LocalJsonPath + fileName);
    }
}