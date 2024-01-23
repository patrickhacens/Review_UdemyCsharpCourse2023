public interface IRecipesUserInteraction
{
    public void ShowMessage(string message);
    public void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PrompotToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}