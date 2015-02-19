using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class ExchangeBits
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int inputNumber = int.Parse(Console.ReadLine());
            
            int mask = 7;
            int getFirstBits = (7 << 3) & inputNumber;
            int getSecondBits = (7 << 24) & inputNumber;

            getFirstBits = getFirstBits << 21;
            getSecondBits = getSecondBits >> 21;
            inputNumber = inputNumber & (~(mask << 3));
            inputNumber = inputNumber & (~(mask << 21));
            inputNumber = inputNumber | getFirstBits;
            inputNumber = inputNumber | getSecondBits;

            Console.WriteLine(Convert.ToString(inputNumber, 2).PadLeft(32, '0'));
            Console.WriteLine(inputNumber);
        }
    }
}
