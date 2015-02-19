using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("Enter >> a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter >> b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter >> h: ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Area is: ");
            Console.WriteLine((a + (b - a) / 2) * h); 
        }
    }
}
