using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class SymbolsAndTriangle
    {
        /// <summary> Problem 9
        /// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:   
        ///        ©
        ///       © ©
        ///      ©   ©
        ///     © © © ©
        /// Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character 
        /// encoding to UTF-8 and assign a Unicode-friendly font in the console.
        /// Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            for (int row = 1; row <= a; row++)
            {
                for (int col = 1; col <= 2 * a - 1; col++)
                {
                    if ((row + col == a + 1) || (col - row == a - 1) || (row == a))
                    {
                        Console.Write("\u00A9");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
