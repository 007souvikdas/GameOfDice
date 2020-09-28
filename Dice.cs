using System;
namespace GameOfDice
{
    sealed class Dice
    {
        private static Dice dice;
        readonly Random random;
        const int maxNumber = 6;
        const int minNumber = 1;
        private Dice()
        {
            random = new Random();
        }

        //Get singleton Instance
        public static Dice KingsDice
        {
            get
            {
                if (dice == null)
                {
                    dice = new Dice();
                }
                return dice;
            }
        }
        public int GetNum()
        {
            return random.Next(minNumber, maxNumber);
        }
    }
}