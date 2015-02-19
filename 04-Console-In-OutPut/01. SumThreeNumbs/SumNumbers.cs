using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumThreeNumbs
{
    /// <summary>Problem 1. Sum of 3 Numbers
    /// Write a program that reads 3 real numbers from the console and prints their sum.
    /// Examples:
    /// a 	b 	c 	sum
    /// 3 	4 	11 	18
    /// -2 	0 	3 	1
    /// 5.5 	4.5 	20.1 	30.1
    /// </summary>
    class SumNumbers
    {
        static void Main()
        {
            //get numbers
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());

            double sumOfNumbers = numberA + numberB + numberC;
            Console.WriteLine(sumOfNumbers);
        }
    }
}
