using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ChechDigit
    {
        static void Main()
        {
            Console.WriteLine("Check number: ");
            int inputNubmer = int.Parse(Console.ReadLine());

            if ((inputNubmer / 100) % 10 == 7)
            {
                Console.WriteLine("True! The third digit (right-to-left) of number {0} is 7", inputNubmer);
            }
            else
            {
                Console.WriteLine("False! The third digit (right-to-left) of number {0} is NOT 7", inputNubmer);
            }
        }
    }
}
