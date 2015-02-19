using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVariables
{
    class Variables
    {
        /// <summary> Problem 1
        ///  Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
        ///  short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        ///  Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
        /// </summary>
        static void Main()
        {
            //int
            int intValueOne = 4825932;
            Console.WriteLine("Integer");
            Console.WriteLine(intValueOne + "\n");
            //end int

            //sbyte
            sbyte sbyteValueOne = -115;
            Console.WriteLine("Sbyte");
            Console.WriteLine(sbyteValueOne + "\n");
            //end sbyte

            //byte
            byte byteValueOne = 97;
            Console.WriteLine("Byte");
            Console.WriteLine(byteValueOne + "\n");
            //end byte

            //short
            short shortValueOne = -10000;
            Console.WriteLine("Short");
            Console.WriteLine(shortValueOne + "\n");
            //end short

            //ushort
            ushort ushortValue = 52130;
            Console.WriteLine("Ushort");
            Console.WriteLine(ushortValue + "\n");
            //end ushort

            //long
            long longValue = 123456789123456789;
            Console.WriteLine("Long");
            Console.WriteLine(longValue + "\n");
            //end long
        }
    }
}
