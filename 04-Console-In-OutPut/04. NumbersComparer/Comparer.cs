using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersComparer
{
    class Comparer
    {
        /// <summary> Problem 4. Number Comparer
        /// Write a program that gets two numbers from the console and prints the greater of them.
        /// Try to implement this without if statements.
        /// Examples:
        /// a 	b 	greater
        /// 5 	6 	6
        /// 10 	5 	10
        /// 0 	0 	0
        /// -5 	-2 	-2
        /// 1.5 1.6 1.6
        /// </summary>
        static void Main()
        {
            Console.Write("Enter Number one: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Enter Number two: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int checkNumbs = (numberOne + numberTwo + Math.Abs(numberOne - numberTwo)) / 2;
            Console.WriteLine("Greater number is: {0}", checkNumbs);

            //second variant
            Console.WriteLine();
            Console.WriteLine("Greater number is: {0}", Math.Max(numberOne, numberTwo));
        }
    }
}
