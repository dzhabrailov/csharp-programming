using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbs
{
    class PrintNumbs
    {
        static void Main()
        {
            int[] numbers = { 1, 101, 1001 };
            foreach (var numb in numbers)
            {
                Console.WriteLine(numb);
            }
        }
    }
}
