using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitwiseExtract
{
    class ExtractBits
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double numberD = double.Parse(Console.ReadLine());

            Console.WriteLine(numberD);
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int deceiverBit = 1 << 3;
            int findBit = number & deceiverBit;

            if (findBit == 0)
            {
                Console.WriteLine("Third bit is '0' " + Convert.ToString(number, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Third bit is '1' " + Convert.ToString(number, 2).PadLeft(16, '0'));
            }
        }
    }
}
