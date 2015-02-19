using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfFive
{
    class FindBiggestOfFive
    {
        /// <summary> 6. The Biggest of Five Numbers
        /// Write a program that finds the biggest of five numbers by using only five if statements.
        /// </summary>
        static void Main()
        {
            //define an array with 5 elements
            double[] numbers = new double[5]; 
            double greatest = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a [" + (i + 1) + "] number: ");
                //fill in array using for loop
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > greatest)
                {
                    greatest = numbers[i];
                }
            }

            Console.WriteLine("The greatest number is {0}", greatest);
        }
    }
}
