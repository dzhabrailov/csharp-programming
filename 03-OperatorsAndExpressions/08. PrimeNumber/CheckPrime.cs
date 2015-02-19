using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class CheckPrime
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool siIntPrime = ((number != 1) && (number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0))
                         || ((number == 2) || (number == 3) || (number == 5) || (number == 7));

            Console.WriteLine(siIntPrime);
        }
    }
}
