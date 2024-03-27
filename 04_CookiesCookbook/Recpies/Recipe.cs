public class Recipe
{
    public IEnumerable<Ingredient> Ingredients { get; }

    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        IEnumerable<string> steps =
        Ingredients.Select(ingredient => $"{ingredient.Name}. {ingredient.PreperationInstructions}");

        return string.Join(Environment.NewLine, steps);

    }
}

