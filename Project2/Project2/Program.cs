using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //30016677 Project 2

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************************************************");
            Console.WriteLine("***** This program will calculate the sum of 5 prices *****\n"); //Title

            double sum = 0;

            for (int i = 1; i<=5; i++) //loop 5 times, asking user for price input and add it to sum
            {
                Console.Write("Please enter the price of item " + i + ": "); //ask user for input
                sum += double.Parse(Console.ReadLine()); //add input to sum
            }

            Console.WriteLine("\nThe sum of these items is $" + sum); //display sum            
            Console.ReadLine();
        }
    }
}
