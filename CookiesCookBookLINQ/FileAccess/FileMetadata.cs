namespace CookiesCookBookLINQ.FileAccess;

public class FileMetadata
{
    public string Path { get; }
    public string Name { get; }
    public FileFormat Format { get; }

    public FileMetadata(string path, string name, FileFormat format)
    {
        Path = path;
        Name = name;
        Format = format;
    }

    public string ToPath() => $"{Path}{Name}.{Format.AsFileExtension()}";
}
