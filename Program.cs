using System;
using System.Collections.Generic;

namespace GameOfDice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"

 ######      ###    ##     ## ########     #######  ########    ########  ####  ######  ######## 
##    ##    ## ##   ###   ### ##          ##     ## ##          ##     ##  ##  ##    ## ##       
##         ##   ##  #### #### ##          ##     ## ##          ##     ##  ##  ##       ##       
##   #### ##     ## ## ### ## ######      ##     ## ######      ##     ##  ##  ##       ######   
##    ##  ######### ##     ## ##          ##     ## ##          ##     ##  ##  ##       ##       
##    ##  ##     ## ##     ## ##          ##     ## ##          ##     ##  ##  ##    ## ##       
 ######   ##     ## ##     ## ########     #######  ##          ########  ####  ######  ######## 


                                                                                    -by Souvik Das
 ");
                int n = -1, m = -1;
                Console.WriteLine("Enter the Number of Players (greater than 1)");
                while (!Validator.ValidateInt(Console.ReadLine(), ref n)) ;

                Console.WriteLine("Enter the max points to accumulate (greater than 1)");
                while (!Validator.ValidateInt(Console.ReadLine(), ref m)) ;

                DiceController dcGame = new DiceController();
                dcGame.StartGame(ref n, ref m);

                System.Console.WriteLine("Press N to stop else press any Key");

                char exitChar = Console.ReadKey().KeyChar;
                if (exitChar == 'N' || exitChar == 'n')
                {
                    System.Console.WriteLine("\nHope u had fun, See u next time on Game Of Dice");
                    System.Console.WriteLine(@"

########  ##    ## ######## 
##     ##  ##  ##  ##       
##     ##   ####   ##       
########     ##    ######   
##     ##    ##    ##       
##     ##    ##    ##       
########     ##    ######## 

");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Let's Bring another Round of Game of Dice");
                    Console.Clear();
                }
            }
        }
    }
}
