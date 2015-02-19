using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    class Number2
    {
        static void Main()
        {
            double number = 12345;
            double numbSqrt = Math.Pow(number, 2);

            Console.WriteLine("The square root of the number 12345 is {0}", numbSqrt);
        }
    }
}
