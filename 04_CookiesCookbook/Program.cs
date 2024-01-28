try
{


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
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! the applicating experienced an " +
        "unexpected error and will have to be closed." +
        $"the error message : {ex.Message}");

    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
}