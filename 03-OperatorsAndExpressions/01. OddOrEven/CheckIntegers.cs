using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class CheckIntegers
    {
        /// <summary>
        /// Problem 1. Odd or Even Integers
        /// Write an expression that checks if given integer is odd or even.
        /// </summary>
        static void Main()
        {
            bool isOdd = true;

            Console.WriteLine("Enter a int numb and check it is odd or even: ");
            int inputNumb = int.Parse(Console.ReadLine());

            Console.WriteLine("Is {0} odd -> " + ((inputNumb % 2 == 0) ? !isOdd : isOdd), inputNumb);
        }
    }
}
