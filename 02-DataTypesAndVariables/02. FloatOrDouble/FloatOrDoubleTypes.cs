using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrDouble
{
    class FloatOrDoubleTypes
    {
        /// <summary> Problem 2 
        /// Float or Double?
        /// Which of the following values can be assigned to a variable of type float and which to a variable of type double:
        /// -> 34.567839023, 12.345, 8923.1234857, 3456.091?
        /// Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        /// </summary>
        static void Main()
        {
            double numberOne = 34.567839023d;
            double numberTwo = 8923.1234857d;
            float numberThree = 12.345f;
            decimal numberFour = 3456.091124875956542151256683467M;

            Console.WriteLine("This number is type double" + " -> " + numberOne + "\n");
            Console.WriteLine("This number is type double" + " -> " + numberTwo + "\n");
            Console.WriteLine("This number is type float" + " -> " + numberThree + "\n");
            Console.WriteLine("This number is type decimal" + " -> " + numberFour + "\n");

        }
    }
}
