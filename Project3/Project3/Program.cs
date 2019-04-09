using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            //30016677 Project 2

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************************");
            Console.WriteLine("***** Can you solve the following algebraic expression? *****");
            Console.WriteLine("********************* 2(x - 3) + x = 12 *********************"); //Title

            int x = 6; //my answer

            Console.Write("\nPlease enter your guess: x = ");
            int guess = int.Parse(Console.ReadLine()); //get user's guess

            if(guess == x)  //if our answers match
            {
                Console.WriteLine("\nWell done! you are correct.");
            }
            else            //if our answers don't match
            {
                Console.WriteLine("\nSorry, that is incorrect.");
            }
            
            Console.ReadLine();

            /*My working:
            2(x-3) + x = 12
            2x - 6 + x - 12 = 0
            3x - 18 = 0
            3x = 18
            x = 6
            */
        }
    }
}
