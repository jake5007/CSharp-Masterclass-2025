namespace GameDataParser.Model;

public class GameData
{
    public GameData(string title, int releaseYear, float rating)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Rating = rating;
    }

    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public float Rating { get; init; }

    public override string ToString() =>
        $"{Title}, released in {ReleaseYear}, rating: {Rating}";
}