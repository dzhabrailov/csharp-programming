using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BitExchange_Advanced
{
    class ExchangeBitsAdv
    {
        static void Main()
        {
            Console.Write("Enter positive number here: \nn = ");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter position of bit to start: \np = ");
            int sBit = int.Parse(Console.ReadLine());

            Console.Write("Enter posiotion of bit to end: \nq = ");
            int fBit = int.Parse(Console.ReadLine());

            Console.Write("Haw many bits you wont to exchange: \nk = ");
            int nBit = int.Parse(Console.ReadLine());
            nBit += 1;

            for (int i = sBit, j = fBit; i < sBit + nBit - 1; i++, j++)
            {
                int mask1 = 1 << i;
                int mask2 = 1 << j;
                int bit1 = (inputNumber & mask1);
                int bit2 = (inputNumber & mask2);
               
                if (bit1 == 0)
                {
                    int replacer = 1 << j;
                    inputNumber = (inputNumber & ~replacer);
                }
                else
                {
                    int replacer = 1 << j;
                    inputNumber = (inputNumber | replacer);
                }
                if (bit2 == 0)
                {
                    int replacer = 1 << i;
                    inputNumber = (inputNumber & ~replacer);
                }
                else
                {
                    int replacer = 1 << i;
                    inputNumber = (inputNumber | replacer);
                }
            }

            Console.WriteLine(Convert.ToString(inputNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("The number after bit changes is: \n{0}", inputNumber);
        }
    }
}
