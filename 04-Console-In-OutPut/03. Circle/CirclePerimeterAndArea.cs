using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    /// <summary> Problem 3. Circle Perimeter and Area
    /// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
    /// Examples:
    /// r 	perimeter 	area
    ///   2 	12.57 	12.57
    /// 3.5 	21.99 	38.48
    /// </summary>
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Write circle radius: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = (Math.PI * (2 * radius));
            double area = (Math.PI * (Math.Pow(radius,2)));

            Console.WriteLine("The perimeter of circle is: {0}", Math.Round(perimeter, 2));
            Console.WriteLine("The area of circle is: {0}", Math.Round(area, 2));
        }
    }
}
