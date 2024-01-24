
FileFormat fileFormat = FileFormat.Txt;


IStringRepository stringRepository = fileFormat == FileFormat.Txt ?
    new StringTextualRepository() :
    new StringJsonRepository();

IIngredientRegistery ingredientRegistery = new IngredientRegistery();

const string fileName = "recipes";

string fileNameWithExt = new FileMetadata(fileName, fileFormat).ToPath();


var recipeRepo =
    new RecipesRepositroy(stringRepository, ingredientRegistery);

var recipeConsoleUserInteraction =
    new RecipesConsoleUserInteraction(ingredientRegistery);

var cookiesRecipesApp =
    new CookiesRecipesApp(recipeRepo, recipeConsoleUserInteraction);

cookiesRecipesApp.Run(fileNameWithExt);

public enum FileFormat
{
    Txt,
    Json
}


public class FileMetadata
{
    public string Name { get; }
    public FileFormat Format { get; }

    public FileMetadata(string name, FileFormat format)
    {
        Name = name;
        Format = format;
    }
    public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
}

public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat file) =>
        file == FileFormat.Txt ? "txt" : "json";
}