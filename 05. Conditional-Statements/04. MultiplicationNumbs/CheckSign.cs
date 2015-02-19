using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationNumbs
{
    /// <summary> 4. Multiplication Sign
    /// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    /// Use a sequence of if operators.
    /// Examples:
    ///  a 	| b  | c  |result
    ///  5 	| 2  | 2  |  +
    /// -2 	|-2  | 1  |  +
    /// -2 	| 4  | 3  |  -
    ///  0 	|-2.5| 4  |  0
    /// -1 	|-0.5|-5.1|  -
    /// </summary>
    class CheckSign
    {
        static void Main()
        {
            Console.Write("Enter value for 'a': ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter value for 'b': ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.Write("Enter value for 'c': ");
            double numberThree = double.Parse(Console.ReadLine());

            if (numberOne < 0 && numberTwo < 0 && numberThree < 0)
            {
                Console.WriteLine("(-)");
            }
            else if (numberOne < 0 && numberTwo > 0 && numberThree > 0)
            {
                Console.WriteLine("(-)");
            }
            else if (numberTwo < 0 && numberOne > 0 && numberThree > 0)
            {
                Console.WriteLine("(-)");
            }
            else if (numberThree < 0 && numberOne > 0 && numberTwo > 0)
            {
                Console.WriteLine("(-)");
            }
            else if ((numberOne < 0 || numberTwo < 0) && numberThree < 0)
            {
                Console.WriteLine("(+)");
            }
            else if (numberOne < 0 && (numberTwo < 0 || numberThree < 0))
            {
                Console.WriteLine("(+)");
            }
            else if ((numberOne < 0 || numberThree < 0) && numberTwo < 0)
            {
                Console.WriteLine("(+)");
            }
            else if ((numberOne == 0) || (numberThree == 0) || (numberTwo == 0))
            {
                Console.WriteLine("0");
            }
        }
    }
}
