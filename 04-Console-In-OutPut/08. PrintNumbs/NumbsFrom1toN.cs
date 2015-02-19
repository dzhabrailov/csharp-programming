using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbs
{
    class NumbsFrom1toN
    {
        /// <summary> Problem 8. Numbers from 1 to n
        /// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
        /// Note: You may need to use a for-loop.
        /// Examples:
        /// input 	output
        ///   3 	  1
        ///   2       3
        ///   5 	  1
        ///   2       3
        ///   4       5
        ///   1 	  1
        ///</summary>
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int inputNumb = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <= inputNumb; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
