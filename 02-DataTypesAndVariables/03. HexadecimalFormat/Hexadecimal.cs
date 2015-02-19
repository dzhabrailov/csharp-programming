using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalFormat
{
    class Hexadecimal
    {
        /// <summary> Problem 3
        /// Variable in Hexadecimal Format
        /// Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
        /// Use Windows Calculator to find its hexadecimal representation.
        /// Print the variable and ensure that the result is 254.
        /// </summary>
        static void Main()
        {
            //number 254 in hex
            int number = 0xFE;

            Console.Write(number + " is ");
            Console.WriteLine("{0:X}", number);
        }
    }
}
