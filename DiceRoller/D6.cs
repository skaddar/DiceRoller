namespace DiceRoller
{
    public class D6 : Die
    {
        public override int Roll()
        {
            LastRoll = rng.Next(1, 7);
            TotalRolls++;
            RollFrequency[LastRoll]++;
            return LastRoll;
        }
    }
}