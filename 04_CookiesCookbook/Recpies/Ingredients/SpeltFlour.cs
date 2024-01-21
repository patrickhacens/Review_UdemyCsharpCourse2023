public class SpeltFlour : Flour
{
    public override int ID => 2;
    public override string Name => "Spelt Flour";
    public override string PreperationInstructions => $"Sieve. {base.PreperationInstructions}";
}

