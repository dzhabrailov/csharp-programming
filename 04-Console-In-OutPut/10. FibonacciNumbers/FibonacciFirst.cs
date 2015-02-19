using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciFirst
    {
        /// <summary> Problem 10. Fibonacci Numbers
        /// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
        /// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
        /// Note: You may need to learn how to use loops.
        /// Examples:
        /// n 	comments
        /// 1 	0
        /// 3 	0 1 1
        /// 10 	0 1 1 2 3 5 8 13 21 34
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main()
        {
            Console.Write("Enter number of the sequence: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
