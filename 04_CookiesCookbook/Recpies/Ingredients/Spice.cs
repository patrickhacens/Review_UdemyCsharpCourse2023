public abstract class Spice : Ingredient
{
    public override string PreperationInstructions => $"take half a teaspoon. {base.PreperationInstructions}";
}

