using System;

namespace DiceRoller
{
    public abstract class Die
    {
        public Random rng = new Random();

        public int LastRoll { get; set; }
        public int TotalRolls { get; set; }
        public int[] RollFrequency { get; set; } = new int[7];

        public abstract int Roll();

        public double GetAverage()
        {
            if (TotalRolls == 0) return 0;

            int sum = 0;
            for (int i = 1; i <= 6; i++)
                sum += i * RollFrequency[i];

            return (double)sum / TotalRolls;
        }

        // get percentage for a given face
        public string GetPercent(int face)
        {
            if (TotalRolls == 0) return "0";
            return ((double)RollFrequency[face] / TotalRolls * 100).ToString("F1");
        }
    }
}
