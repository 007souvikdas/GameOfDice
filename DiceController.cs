using System;
using System.Collections.Generic;

namespace GameOfDice
{
    class DiceController
    {
        // Returns the list of order of players
        const int InvalidDiceRoll = 1;
        public List<Player> GetPlayerOrderedList(int n)
        {
            List<Player> players = new List<Player>();
            List<int> nums = new List<int>();

            Random random = new Random();

            while (nums.Count < n)
            {
                int tempRandomNumber = random.Next(1, n + 1);
                if (nums.IndexOf(tempRandomNumber) != -1)
                {
                    continue;
                }
                nums.Add(tempRandomNumber);
            }

            foreach (int i in nums)
            {
                players.Add(new Player("Player-" + i));
            }
            return players;
        }

        //starts the Game of Dice
        public void StartGame(ref int n, ref int m)
        {

            Displayer displayer = new Displayer();

            List<Player> players = this.GetPlayerOrderedList(n);
            List<Player> winners = new List<Player>();

            displayer.PrintPlayerOrder(players);

            System.Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            Console.Clear();

            int count = 1;
            while (players.Count != 0)
            {
                System.Console.WriteLine("==============Step" + count + "=============");
                count++;
                int i = 0;
                while (i < players.Count)
                {
                    if (!players[i].SkipChance)
                    {
                        System.Console.WriteLine($"{players[i].Name}, it's ur chance to throw the dice (press 'r')");
                        while (!Validator.ValidateDiceStr(Console.ReadKey().KeyChar)) ;

                        System.Console.WriteLine();

                        int random = Dice.KingsDice.GetNum();

                        players[i].Score += random;
                        System.Console.WriteLine("your Dice roll returned :" + random);


                        if (random == InvalidDiceRoll && players[i].LastDiceRoll == InvalidDiceRoll)
                        {
                            players[i].SkipChance = true;
                            System.Console.WriteLine("OOPS!!! Ur next turn will be skipped as a penalty");
                        }
                        players[i].LastDiceRoll = random;


                        if (players[i].Score >= m)
                        {
                            System.Console.WriteLine("WOW!!! U Won \nPlayer " + players[i].Name + " got " + (winners.Count + 1) + " Place \n");
                            players[i].WinningPosition = winners.Count + 1;
                            winners.Add(players[i]);
                            players.RemoveAt(i);
                        }

                        if (winners.Count == n)
                        {
                            System.Console.WriteLine("All the player finished");
                            displayer.PrintFinalScoreboard(winners);

                            System.Console.WriteLine("If u like the game, Hire Souvik Das(souvikddss@gmail.com)\n");
                            break;
                        }

                        if (random == 6)
                        {
                            System.Console.WriteLine("WOW!!! Nice hand , U Got another chance :)");
                            continue;
                        }
                        else
                        {
                            displayer.PrintScore(players, winners);
                        }
                    }
                    else
                    {
                        System.Console.WriteLine($"{players[i].Name} chance Skipped");
                        players[i].SkipChance = false;
                    }
                    i++;
                }
            }
        }
    }
}