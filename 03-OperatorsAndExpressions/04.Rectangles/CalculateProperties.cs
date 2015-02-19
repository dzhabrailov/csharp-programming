using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    /// <summary>
    /// Problem 4. Rectangles
    /// Write an expression that calculates rectangle’s perimeter and area by given width and height.
    /// </summary>
    class CalculateProperties
    {
        //this method calculate the area
        static double CalculateArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        //this method calculate the perimeter
        static double CalculatePerimeter(double width, double height)
        {
            double perimeter = (2 * width) + (2 * height);
            return perimeter;
        }

        public static void Main()
        {
            Console.Write("Enter value for width: ");
            double width = double.Parse(Console.ReadLine());
          
            Console.Write("Enter value for height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Rectangle's area is: " + CalculateArea(width, height));
            Console.WriteLine("Rectangle's perimeter is: " + CalculatePerimeter(width, height));
        }
    }
}
