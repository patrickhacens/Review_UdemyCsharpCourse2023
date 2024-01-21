public class Butter : Ingredient
{
    public override int ID => 3;
    public override string Name => "Butter";
    public override string PreperationInstructions => $"Melt on low heat. {base.PreperationInstructions}";
}

