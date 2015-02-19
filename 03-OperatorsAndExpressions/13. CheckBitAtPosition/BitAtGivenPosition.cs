using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtPosition
{
    class BitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for 'n': ");
            int numberN = int.Parse(Console.ReadLine());
          
            Console.Write("Enter value for 'p': ");
            int numberPosition = int.Parse(Console.ReadLine());

            int moveBit = numberN >> numberPosition;
            int foundBit = moveBit & 1;
            bool isOne = foundBit == 1;

            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
            Console.WriteLine("Bit of position {0} is '1' = {1}", numberPosition, isOne);
        }
    }
}
