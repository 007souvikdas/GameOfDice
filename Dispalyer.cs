using System.Collections.Generic;
using System.Threading;

namespace GameOfDice
{
    class Displayer
    {
        public void PrintScore(List<Player> persons, List<Player> winners)
        {

            if (winners.Count > 0)
            {
                System.Console.WriteLine("\n !!!!!!!!!!!!!!!!!!! WINNER SCOREBOARD !!!!!!!!!!!!!!!!!!");
                System.Console.WriteLine(string.Format("|{0,15}            |{1,15}             |", "Name", "Score"));

                foreach (Player p in winners)
                {
                    System.Console.WriteLine(string.Format("|{0,15}            |{1,15}             |", p.Name, p.Score));
                }
                System.Console.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
            }

            if (persons.Count > 0)
            {
                var newPersonList = new List<Player>(persons);
                newPersonList.Sort(new PersonComparer());
                newPersonList.Reverse();

                System.Console.WriteLine("\n *************** ACTIVE USERS SCOREBOARD **************");
                System.Console.WriteLine(string.Format("|{0,15}            |{1,15}           |", "Name", "Score"));

                foreach (Player p in newPersonList)
                {
                    System.Console.WriteLine(string.Format("|{0,15}            |{1,15}           |", p.Name, p.Score));
                }
                System.Console.WriteLine(" *********************************************************");
                System.Console.WriteLine();
            }
        }
        public void PrintPlayerOrder(List<Player> persons)
        {
            System.Console.WriteLine("SELECTING ORDER OF PLAYERS...\n");

            Thread.Sleep(1000);
            System.Console.WriteLine(" ========= SELECTED ORDER OF PLAYERS ============");
            foreach (Player player in persons)
            {
                System.Console.WriteLine(string.Format("|{0,27}                     |", player.Name));
            }
            System.Console.WriteLine(" ================================================");
        }

        public void PrintFinalScoreboard(List<Player> players)
        {
            System.Console.WriteLine("\n !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! SCOREBOARD !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            System.Console.WriteLine(string.Format("|{0,15}            |{1,15}             |{2,15}             |", "Position", "Name", "Score"));
            foreach (Player p in players)
            {
                System.Console.WriteLine(string.Format("|{0,15}            |{1,15}             |{2,15}             |", p.WinningPosition, p.Name, p.Score));
            }

            System.Console.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }
}