using System;
using System.Collections.Generic;
using System.Threading;


namespace GameOfDice
{    
    class DiceController{
        public List<Person> GetPlayerOrderedList(int n){
            List<Person> persons = new List<Person>();
            List<int> nums = new List<int>();

            Random random = new Random();

            while(nums.Count < n ){
                int tempRandomNumber = random.Next(1,n+1);
                if(nums.IndexOf(tempRandomNumber)!=-1){
                    continue;
                }
                nums.Add(tempRandomNumber);
            }

            foreach(int i in nums){
                persons.Add(new Person("Person-"+i));
            }
            return persons;
        }

    public void StartGame(ref int n,ref int m){
        
            Displayer displayer= new Displayer();          

            List<Person> persons =this.GetPlayerOrderedList(n);
            List<Person> winners=new List<Person>();

            displayer.PrintPlayerOrder(persons);

            System.Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            Console.Clear();

            int count=1;
            while(persons.Count!=0){
            System.Console.WriteLine("==============Step"+count+"=============");
            count++;
            int i=0;
            while(i<persons.Count)
            {
                if(!persons[i].SkipChance)
                {
             System.Console.WriteLine($"{persons[i].Name}, it's ur chance to throw the dice (press 'r')");
             while(!Validator.ValidateDiceStr(Console.ReadKey().KeyChar));

             System.Console.WriteLine();

             int random = Dice.KingsDice.GetNum();             
             
             persons[i].Score+= random;  
             System.Console.WriteLine("your Dice roll returned :"+random);


             if(random ==1 && persons[i].LastDiceRoll==1){
                 persons[i].SkipChance= true;
                 System.Console.WriteLine("OOPS!!! Ur next turn will be skipped as a penalty");
             }
             persons[i].LastDiceRoll = random;


             if(persons[i].Score>=m){
                System.Console.WriteLine("WOW!!! U Won \nPlayer "+persons[i].Name+" got "+(winners.Count+1)+" Place \n");
                persons[i].WinningPosition = winners.Count+1;
                winners.Add(persons[i]);
                persons.RemoveAt(i);                
             }
            
             if (winners.Count == n){
                 System.Console.WriteLine("All the player finished");
                 displayer.PrintFinalScoreboard(winners);

                 System.Console.WriteLine("If u like the game, Hire Souvik Das(souvikddss@gmail.com)\n");
                 break;
             }

             if(random == 6){
                 System.Console.WriteLine("WOW!!! Nice hand , U Got another chance :)");
                 continue;
             }else
             {
                displayer.printScore(persons,winners);
             }
                }else{                    
                    System.Console.WriteLine($"{persons[i].Name} chance Skipped");
                    persons[i].SkipChance = false;
                }
             i++;
            }
        }
    }
    }

}