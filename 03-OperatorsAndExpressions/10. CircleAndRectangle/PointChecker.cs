using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndRectangle
{
    class PointChecker
    {
        static void Main()
        {
            Console.Write("Set value for 'X' = ");
            double valueX = double.Parse(Console.ReadLine());
           
            Console.Write("Set value for 'Y' = ");
            double valueY = double.Parse(Console.ReadLine());

            bool isInCircle = (valueX - 1) * (valueX - 1) + (valueY - 1) * (valueY - 1) <= (1.5 * 1.5);
            bool isOutRectangle = valueX > 1 || valueX < 6 && valueY > -1 || valueY < 2;

            if (isInCircle == true && isOutRectangle == true)
            {
                Console.WriteLine("Yes");
            }
            else if (valueX == 0 || valueY == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
