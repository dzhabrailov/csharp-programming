using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeNumbers
{
    class SortNumbs
    {
        /// <summary> 7. Sort 3 Numbers with Nested Ifs
        /// Write a program that enters 3 real numbers and prints them sorted in descending order.
        /// Use nested if statements. Note: Don’t use arrays and the built-in sorting functionality.
        /// </summary>
        static void Main()
        {
            Console.Write("Enter first number : ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter second number : ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.Write("Enter third number : ");
            double numberThree = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo && numberOne > numberThree)
            {
                double tempNumber = numberThree;
                numberThree = numberOne;
                numberOne = tempNumber;

                if (numberOne > numberTwo)
                {
                    tempNumber = numberOne;
                    numberOne = numberTwo;
                    numberTwo = tempNumber;
                }
            }
            else if (numberTwo > numberThree)
            {
                double tempNumber = numberThree;
                numberThree = numberTwo;
                numberTwo = tempNumber;

                if (numberOne > numberTwo)
                {
                    tempNumber = numberOne;
                    numberOne = numberTwo;
                    numberTwo = tempNumber;
                }
            }
            else if (numberOne > numberTwo)
            {
                double tempNumber = numberOne;
                numberOne = numberTwo;
                numberTwo = tempNumber;
            }

            Console.WriteLine("Sorted numbers: {0} {1} {2}", numberThree, numberTwo, numberOne);
        }
    }
}
