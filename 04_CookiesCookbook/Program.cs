

using System.Collections.Generic;

Ingredient wheatFlour = new Ingredient(1, "Wheat flour", "Sieve. Add to other ingredients.");
Ingredient coconutFlour = new Ingredient(2, "Coconut flour", "Sieve. Add to other ingredients.");
Ingredient butter = new Ingredient(3, "Butter", "Melt on low heat. Add to other ingredients.");
Ingredient chocolate = new Ingredient(3, "Chocolate", "Melt in a water bath. Add to other ingredients.");
Ingredient sugar = new Ingredient(3, "Sugar", "Add to other ingredients.");


string fileName = "recipes.txt";

if (File.Exists(fileName))
{
    List<Recipe> recipes = new List<Recipe>();
    string[] recipesID = File.ReadAllLines(fileName);
    foreach (string recipe in recipesID)
    {
        string[] recipeID = recipe.Split(',');
        foreach (string item in recipeID)
        {
            switch (item)
            {
                case "1":
                    recipes.Add(new Recipe())
                default:
                    break;
            }
        }
    }
}
else
{

}




