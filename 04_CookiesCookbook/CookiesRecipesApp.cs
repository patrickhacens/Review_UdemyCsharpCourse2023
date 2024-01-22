public class CookiesRecipesApp
{
    private readonly IRecipesRepositroy _recipesRepositroy;
    private readonly IRecipesUserInteraction _recipesUserInteraction;
    public CookiesRecipesApp(RecipesRepositroy recipesRepositroy, RecipesConsoleUserInteraction recipesUserInteraction)
    {
        _recipesRepositroy = recipesRepositroy;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run(string filePath)
    {
        var allRecipes = _recipesRepositroy.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);
        _recipesUserInteraction.PrompotToCreateRecipe();

        //var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        //if (ingredients.Count > 0)
        //{
        //    var recpie = new Recipe(ingredients);
        //    allRecipes.Add(recpie);
        //    _recipesRepositroy.Write(filePath, allRecipes);

        //    _recipesUserInteraction.ShowMessage("Recpie added");
        //    _recipesUserInteraction.ShowMessage(recpie.ToString());

        //}
        //else
        //{
        //    _recipesUserInteraction.ShowMessage("No Ingredients have been selected." +
        //        "Recpie will not be saved");
        //}
        _recipesUserInteraction.Exit();
    }
}