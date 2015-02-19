using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPoint
{
    class FloatPoint
    {
        /// <summary> Problem 13
        /// Comparing Floats: Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        /// Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
        /// Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
        /// </summary>
        static void Main()
        {
            double eps = 0.000001;
            // firstNumber = 5.00000001
            Console.Write("Enter first number >> ");
            double firstNumber = double.Parse(Console.ReadLine());

            // secondNumber = 5.00000003
            Console.Write("Enter second number >> ");
            double secondNumber = double.Parse(Console.ReadLine());

            bool isEqual = Math.Abs(firstNumber - secondNumber) < eps;

            Console.WriteLine("The numbers are equal: {0}", isEqual);
        }
    }
}
