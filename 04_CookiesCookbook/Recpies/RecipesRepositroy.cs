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
        var recipesAsStrings = allRecipes
            .Select(recipe =>
            {
                var allIds = recipe.Ingredients
                    .Select(ingredient => ingredient.ID);
                return string.Join(Separator, allIds);
            });

        _stringRepository.Write(filePath, recipesAsStrings.ToList());
    }

    public List<Recipe> Read(string filePath)
    {

        return _stringRepository.Read(filePath)
               .Select(RecipeFromString)
               .ToList();

    }

    private Recipe RecipeFromString(string recipe)
    {
        var ingredients = recipe.Split(Separator)
            .Select(int.Parse)
            .Select(_ingredientRegistery.GetByID);

        return new Recipe(ingredients);
    }

}
