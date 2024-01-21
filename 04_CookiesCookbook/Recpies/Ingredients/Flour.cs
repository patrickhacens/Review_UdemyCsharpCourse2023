public abstract class Flour : Ingredient
{
    public override string PreperationInstructions => $"Sieve. {base.PreperationInstructions}";
}

