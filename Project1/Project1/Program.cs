using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //30016677 Project 1

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******************************************************************");
            Console.WriteLine("***** This program will give you the result of base^exponent *****\n");//Title

            Console.Write("Please enter the value of the base: ");
            double baseNum = double.Parse(Console.ReadLine()); //Read user input for base
            Console.Write("Please enter the value of the exponent: ");
            int exponentNum = int.Parse(Console.ReadLine()); //Read user input for exponent
            double result = 1;

            for(int i = 1; i <= exponentNum; i++) //loop as many times as user's exponent value
            {
                result *= baseNum; //do math
            }

            Console.WriteLine("\n" + baseNum + "^" + exponentNum + " = " + result); //display result
            Console.ReadLine();
        }
    }
}
