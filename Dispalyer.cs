using System.Collections.Generic;
using System.Threading;

namespace GameOfDice{
    class Displayer{
    public void printScore(List<Person> persons,List<Person> winners){
        
            if(winners.Count>0){
            System.Console.WriteLine("\n !!!!!!!!!!!!!!!!!!! WINNER SCOREBOARD !!!!!!!!!!!!!!!!!!");
            System.Console.WriteLine(string.Format("|{0,15}            |{1,15}             |","Name","Score"));

            foreach(Person p in winners ){
                System.Console.WriteLine(string.Format("|{0,15}            |{1,15}             |",p.Name,p.Score));
            }
            System.Console.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
            }

            if(persons.Count>0){
                var newPersonList = new List<Person>(persons);
                newPersonList.Sort(new PersonComparer());
                newPersonList.Reverse();

                System.Console.WriteLine("\n *************** ACTIVE USERS SCOREBOARD **************");
                System.Console.WriteLine(string.Format("|{0,15}            |{1,15}           |","Name","Score"));

            foreach(Person p in newPersonList){
                System.Console.WriteLine(string.Format("|{0,15}            |{1,15}           |",p.Name,p.Score));
            }
                System.Console.WriteLine(" *********************************************************");
            System.Console.WriteLine();
            }
        }
    public void PrintPlayerOrder(List<Person> persons){
        System.Console.WriteLine("SELECTING ORDER OF PLAYERS...\n");
        
        Thread.Sleep(1000);
        System.Console.WriteLine(" ========= SELECTED ORDER OF PLAYERS ============");        
        foreach(Person player in persons){
            System.Console.WriteLine(string.Format("|{0,27}                     |",player.Name));
        }
        System.Console.WriteLine(" ================================================");
    }

    public void PrintFinalScoreboard(List<Person> players){
        System.Console.WriteLine("========== SCOREBOARD ========");
        System.Console.WriteLine("Position : | Name:     | Score:   ");

            foreach(Person p in players ){
                System.Console.WriteLine(p.WinningPosition+ ":" + p.Name+":"+ p.Score);
            }
            System.Console.WriteLine("==============================");
    }
}
}