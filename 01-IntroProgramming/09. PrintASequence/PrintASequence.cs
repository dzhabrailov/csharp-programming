using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int numbs = int.Parse(Console.ReadLine());

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
