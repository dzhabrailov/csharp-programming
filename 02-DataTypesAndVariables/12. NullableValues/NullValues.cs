using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableValues
{
    class NullValues
    {
        /// <summary> Problem 12
        /// Null Values Arithmetic
        /// Create a program that assigns null values to an integer and to a double variable.
        /// Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.
        /// </summary>
        static void Main()
        {
            int? integerNumb = null;
            double? doubleNumb = null;

            Console.WriteLine("With null literals:");
            Console.WriteLine(integerNumb + "\n" + doubleNumb);

            integerNumb = 5;
            doubleNumb = 2.5;

            Console.WriteLine("With asigned values:");
            Console.WriteLine(integerNumb + "\n" + doubleNumb);
        }
    }
}
