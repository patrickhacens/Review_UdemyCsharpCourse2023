public interface IRecipesRepositroy
{
    public List<Recipe> Read(string filePath);
    void Write(string filePath, List<Recipe> allRecipes);
}