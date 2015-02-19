using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Quadratic
    {
     
        /// <summary> Problem 6. Quadratic Equation
        /// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
        /// Examples:
        ///  a 	  b  c 	roots
        ///  2 	  5 -3 	x1=-3; x2=0.5
        /// -1 	  3  0 	x1=3; x2=0
        /// -0.5  4 -8 	x1=x2=4
        ///  5    2  8 	no real roots
        /// </summary>
        static void Main()
        {
            double x1;
            double x2;

            Console.Write("Enter \"a\": ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter \"b\": ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("Enter \"c\": ");
            int c = Int32.Parse(Console.ReadLine());

            //discriminant
            int d = b * b - 4 * a * c; 

            if (d == 0)
            {
                x1 = x2 = -b / (2 * a);
                
                Console.WriteLine("The only solution is x = {0,8:f4}.", x1);
                Console.ReadLine();
            }
            /*If d<0, no solutions are possible*/
            else if (d < 0) 
            {
                Console.WriteLine("There are no possible solutions");
                Console.ReadLine();
            }
            /*If d>0, there are two possible solutions*/
            else 
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
               
                Console.WriteLine("x1 = {0,8:f4} and x2 = {1,8:f4}", x1, x2);
            }
        }
    }
}
