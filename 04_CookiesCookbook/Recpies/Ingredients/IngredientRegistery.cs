public class IngredientRegistery : IIngredientRegistery
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
        foreach (var item in All)
        {
            if (item.ID == id)
                return item;
        }
        return null;
    }
}