using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbs
{
    class Formatting
    {
     
        /// <summary> Problem 5. Formatting Numbers
        /// Write a program that reads 3 numbers:
        /// integer a (0 <= a <= 500)
        /// floating-point b
        /// floating-point c
        /// The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        /// The number a should be printed in hexadecimal, left aligned. Then the number a should be printed in binary form, padded with zeroes
        /// The number b should be printed with 2 digits after the decimal point, right aligned. The number c should be printed with 3 digits after the decimal point, left aligned.
        /// Examples:
        /// a 	b 	c 	result
        /// 254 	11.6 	0.5 	FE |0011111110| 11.60|0.500 |
        /// 499 	-0.5559 	10000 	1F3 |0111110011| -0.56|10000.000 |
        /// 0 	3 	-0.1234 	0 |0000000000| 3.00|-0.123 |
        /// </summary>
        static void Main()
        {
            Console.Write("Enter a: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 499) Console.WriteLine("Invalid input!!!");

            Console.Write("Enter b: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Invalid input!!!");

            Console.Write("Enter c: ");
            double c;
            while (!double.TryParse(Console.ReadLine(), out c)) Console.WriteLine("Invalid input!!!");

            string someVariable = String.Empty;
            Console.Write("|{0:X}{1, -10}|{2}|{1, -10}{3:F2}|", a, someVariable, Convert.ToString(a, 2).PadLeft(10, '0'), b);

            bool revision = Convert.ToString(c).IndexOf(".") > 0;
            Console.WriteLine(revision ? "{0:0.000}" : "{0}", c);

            Console.WriteLine();
        }
    }
}
