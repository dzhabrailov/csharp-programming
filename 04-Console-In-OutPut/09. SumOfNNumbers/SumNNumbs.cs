using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumNNumbs
    {
        /// <summary> Problem 9. Sum of n Numbers
        /// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
        /// Examples:
        /// numbers 	sum
        /// 3 	        90
        /// 20 	
        /// 60 	
        /// 10 	
        /// ----------------
        /// 5 	        6.5
        /// 2 	
        /// -1 	
        /// -0.5 	
        /// ----------------
        /// 4 	
        /// 2 	
        /// 1 	
        /// 1           4
        /// </summary>
        static void Main()
        {
            double number;
            double counter = 0;
            double sum = 0;

            Console.Write("Enter count of numbers that you want to sum: ");
            double length = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Enter number: ");
                string firstNumber = Console.ReadLine();

                if (double.TryParse(firstNumber, out number))
                {
                    sum += number;
                    counter++;
                }
                else
                {
                    Console.WriteLine("You enter wrong format number!");
                }

            } while (counter < length);

            Console.WriteLine("The Sum is: {0}", sum);
        }
    }
}
