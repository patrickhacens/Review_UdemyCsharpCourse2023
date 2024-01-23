public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IngredientRegistery _ingredientRegistery;

    public RecipesConsoleUserInteraction(IngredientRegistery ingredientRegistery)
    {
        _ingredientRegistery = ingredientRegistery;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to exist.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Any())
        {
            Console.WriteLine("Existing recpies are: " + Environment.NewLine);
            int counter = 1;
            foreach (Recipe recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                counter++;
            }
        }
    }

    public void PrompotToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " +
            "Available ingredients are:");

        foreach (Ingredient ingredient in _ingredientRegistery.All)
        {
            Console.WriteLine(ingredient);
        }

    }

    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        bool shallStop = false;
        string input;
        List<Ingredient> ingredients = new List<Ingredient>();
        do
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
            input = Console.ReadLine();
            if (int.TryParse(input, out int id))
            {
                Ingredient selectedIngredient = _ingredientRegistery.GetByID(id);
                if (selectedIngredient is not null)
                {
                    ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                shallStop = true;
            }

        } while (!shallStop);

        return ingredients;
    }
}

public class IngredientRegistery
{
    public IEnumerable<Ingredient> All { get; }
    = new List<Ingredient>()
    {
        new WheatFlour(),
        new CoconutFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardmom(),
        new Cinnamon(),
        new CocoaPowder()
    };

    public Ingredient GetByID(int id)
    {
        return All.Where((i) => i.ID == id).First();
    }
}