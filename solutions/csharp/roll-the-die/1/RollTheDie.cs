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
        Random random = new Random();
        double strength = random.NextDouble() * 100.0;
        return strength;
    }
}
