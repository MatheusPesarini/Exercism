public class Player
{
    public int RollDie()
    {
        Random random = new Random();
        int dice = random.Next(1, 19);
        return dice;
    }

    public double GenerateSpellStrength()
    {
        return Random.Shared.NextDouble() * 100.0;
    }
}
