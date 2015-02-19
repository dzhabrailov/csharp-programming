using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class CheckPoint
    {
        static void Main()
        {
            Console.Write("Set value for 'X' = ");
            double valueX = double.Parse(Console.ReadLine());
          
            Console.Write("Set value for 'Y' = ");
            double valueY = double.Parse(Console.ReadLine());

            bool isPointsInside = (valueX * valueX) + (valueY * valueY) <= (2 * 2);
            Console.WriteLine("Inside the circle = " + isPointsInside);
        }
    }
}
