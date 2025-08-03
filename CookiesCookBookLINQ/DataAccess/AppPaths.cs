namespace CookiesCookBookLINQ.DataAccess;

public static class AppPaths
{
    public static readonly string BasePath = AppDomain.CurrentDomain.BaseDirectory;

    public static string LocalJsonPath =>
        Path.Combine(BasePath, @"..\..\..\Data\Json\");
    public static string LocalTxtPath =>
        Path.Combine(BasePath, @"..\..\..\Data\Txt\");
}
