public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat file) =>
        file == FileFormat.Txt ? "txt" : "json";
}