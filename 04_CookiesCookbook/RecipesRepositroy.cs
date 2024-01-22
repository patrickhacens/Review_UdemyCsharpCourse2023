public class RecipesRepositroy : IRecipesRepositroy
{
    public List<Recipe> Read(string filePath)
    {
        return new List<Recipe>()
        {
            new Recipe(new List<Ingredient>()
            {
                new WheatFlour(),
                new Butter(),
                new Sugar()

            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(),
                new CoconutFlour(),
                new Cinnamon()
            })
        };
    }
}