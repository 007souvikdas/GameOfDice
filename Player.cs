using System.Collections.Generic;

namespace GameOfDice
{
    //Player Model class
    class Player
    {
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
        }
        public int Score { get; set; }

        public int WinningPosition { get; set; } = -1;

        public int LastDiceRoll { get; set; } = -1;

        public bool SkipChance = false;

    }

    class PersonComparer : IComparer<Player>
    {
        public int Compare(Player first, Player second)
        {
            return first.Score.CompareTo(second.Score);
        }
    }
}

