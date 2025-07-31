namespace GameDataParser.DataAccess;

public static class AppPaths
{
    public static readonly string BasePath = AppDomain.CurrentDomain.BaseDirectory;

    public static string LocalJsonPath =>
        Path.Combine(BasePath, @"..\..\..\Data\Json\");
    public static string LocalLogPath =>
        Path.Combine(BasePath, @"..\..\..\Data\Log\");
}
