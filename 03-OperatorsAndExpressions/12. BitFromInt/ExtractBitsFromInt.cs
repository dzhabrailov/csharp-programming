using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFromInt
{
    class ExtractBitsFromInt
    {
        static void Main()
        {
            Console.Write("Enter value for 'n': ");
            int numberN = int.Parse(Console.ReadLine());
          
            Console.Write("Enter value for 'p': ");
            int numberPosition = int.Parse(Console.ReadLine());

            int deceiverBit = 1 << numberPosition;
            int findBit = numberN & deceiverBit;

            if (findBit == 0)
            {
                Console.WriteLine("Bit of position {0} is '0'", numberPosition);
                Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Bit of position {0} is '1'", numberPosition);
                Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
            }
        }
    }
}
