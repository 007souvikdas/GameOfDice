using System;

namespace GameOfDice
{
    class Validator
    {
        public static bool ValidateInt(string input, ref int n)
        {
            try
            {
                n = int.Parse(input);
                if (n < 1)
                {
                    throw new Exception("Invalid Arguments");
                }
                return true;
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Please enter a valid number (greater than 1)");
                return false;
            }

        }

        public static bool ValidateDiceStr(char input)
        {
            try
            {
                if (!(input == 'r'))
                {
                    throw new Exception("Invalid Arguments");
                }
                return true;
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Please enter 'r' to roll dice");
                return false;
            }
        }


    }
}