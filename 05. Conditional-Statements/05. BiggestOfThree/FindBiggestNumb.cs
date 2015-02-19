using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThree
{
    class FindBiggestNumb
    {
        /// <summary> The Biggest of 3 Numbers
        /// Write a program that finds the biggest of three numbers.
        /// </summary>
        static void Main()
        {
            Console.Write("Enter value for 'a' : ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter value for 'b' : ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.Write("Enter value for 'c : ");
            double numberThree = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine("Greater number is {0}", numberOne);
                }
            }
            else if (numberTwo > numberThree)
            {
                Console.WriteLine("Greater number is {0}", numberTwo);
            }
            else
            {
                Console.WriteLine("Greater number is {0}", numberThree);
            }
        }
    }
}
