using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariables
{
    class ExchangeVars
    {
        /// <summary> Problem 9
        /// Exchange Variable Values
        /// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values 
        /// by using some programming logic. Print the variable values before and after the exchange.
        /// </summary>
        static void Main()
        {
            int varA = 5;
            int varB = 10;
            Console.WriteLine("Before");
            Console.WriteLine(varA);
            Console.WriteLine(varB + "\n");

            int varC = varA;

            varA = varB;
            varB = varC;
            Console.WriteLine("After");
            Console.WriteLine(varA);
            Console.WriteLine(varB);
        }
    }
}
