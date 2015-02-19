using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitPosition
{
    class BitPosition
    {
        static void Main()
        {
            Console.Write("Enter value for 'n': ");
            int numberN = int.Parse(Console.ReadLine());
          
            Console.Write("Enter value for 'p': ");
            int numberPosition = int.Parse(Console.ReadLine());
            
            Console.Write("Enter value for 'v'- 0 or 1: ");
            int valueBit = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));

            if (valueBit == 1)
            {
                int setOne = 1 << numberPosition;
                int findBitOne = numberN | setOne;
               
                Console.WriteLine(Convert.ToString(findBitOne, 2).PadLeft(16, '0'));
                Console.WriteLine(findBitOne);
            }
            else
            {
                int setZero = ~(1 << numberPosition);
                int findBitZero = numberN & setZero;
               
                Console.WriteLine(Convert.ToString(findBitZero, 2).PadLeft(16, '0'));
                Console.WriteLine(findBitZero);
            }
        }
    }
}
