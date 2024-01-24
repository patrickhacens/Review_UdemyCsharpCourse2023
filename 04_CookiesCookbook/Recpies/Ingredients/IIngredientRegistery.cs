public interface IIngredientRegistery
{
    IEnumerable<Ingredient> All { get; }

    Ingredient GetByID(int id);
}