using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFiveNumbs
{
    class Sumator
    {
        /// <summary> Problem 7. Sum of 5 Numbers
        /// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
        /// Examples:
        /// numbers 	        sum
        /// 1 2 3 4 5 	        15
        /// 10 10 10 10 10     	50
        /// 1.5 3.14 8.2 -1 0 	11.84
        /// </summary>
        static void Main()
        {
            double sum = 0;

            Console.Write("Enter five numbers in a single line - separated by a space: ");
            string[] inputNumbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                sum += Convert.ToDouble(inputNumbers[i]);
            }

            Console.WriteLine("The Sum is: {0}", sum);
        }
    }
}
