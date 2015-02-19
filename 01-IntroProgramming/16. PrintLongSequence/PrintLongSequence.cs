using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int numbs = 1000;

            for (int i = 2; i <= numbs; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
