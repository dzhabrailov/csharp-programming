using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacter
{
    class UniChars
    {
        /// <summary> Problem 4
        ///  Unicode Character
        ///  Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
        ///  using the \u00XX syntax, and then print it. 
        ///  Hint: first, use the Windows Calculator to find the hexadecimal representation of 42.
        ///  The output should be *.
        /// </summary>
        static void Main()
        {
            // *
            char asterix = (char)42;

            // H
            char charH = (char)72;
            Console.Write(asterix + "  " + charH);

            // e
            char ncharE = (char)101;
            Console.Write("  " + ncharE);

            // l l
            char charL = (char)108;
            Console.Write("  " + charL + "  " + charL);

            // o
            char charO = (char)111;
            Console.Write("  " + charO);

            // !
            char charSign = (char)33;
            Console.WriteLine("  " + charSign + "  " + asterix);
        }
    }
}
