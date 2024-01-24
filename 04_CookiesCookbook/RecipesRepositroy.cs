public class RecipesRepositroy : IRecipesRepositroy
{
    private const string Separator = ",";
    private readonly IStringRepository _stringRepository;
    private readonly IIngredientRegistery _ingredientRegistery;

    public RecipesRepositroy(IStringRepository stringRepository,
        IIngredientRegistery ingredientRegistery)
    {
        _stringRepository = stringRepository;
        _ingredientRegistery = ingredientRegistery;
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = new List<string>();
        foreach (var recipe in allRecipes)
        {
            var allIds = new List<int>();
            foreach (var ingredient in recipe.Ingredients)
            {
                allIds.Add(ingredient.ID);
            }
            recipesAsStrings.Add(string.Join(Separator, allIds));
        }

        _stringRepository.Write(filePath, recipesAsStrings);
    }

    public List<Recipe> Read(string filePath)
    {
        List<string> recipesFromFile = _stringRepository.Read(filePath);
        List<Recipe> recipes = new List<Recipe>();
        foreach (string recipe in recipesFromFile)
        {
            recipes.Add(RecipeFromString(recipe));
        }
        return recipes;
    }

    private Recipe RecipeFromString(string recipe)
    {
        string[] textualIds = recipe.Split(Separator);
        List<Ingredient> ingredients = new List<Ingredient>();
        foreach (string textualId in textualIds)
        {
            int id = int.Parse(textualId);
            Ingredient ingredient = _ingredientRegistery.GetByID(id);
            ingredients.Add(ingredient);
        }
        return new Recipe(ingredients);
    }

}
