using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfGreater
{
    class CheckGreater
    {
        /// <summary> Problem 1. Exchange If Greater
        /// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
        /// Examples:
        /// | a  | b |result
        /// | 5	 | 2 |2 5
        /// | 3  | 4 |3 4
        /// |5.5 |4.5|4.5 5.5
        /// </summary>
        static void Main()
        {
            Console.Write("Enter value for 'a': ");
            double firstNumb = double.Parse(Console.ReadLine());

            Console.Write("Enter value for 'b': ");
            double secondNumb = double.Parse(Console.ReadLine());

            #region first decision
            if (firstNumb > secondNumb)
            {
                double tempNumb = firstNumb;
                firstNumb = secondNumb;
                secondNumb = tempNumb;
            }
            Console.WriteLine("First Number is {0}, second number is {1}", firstNumb, secondNumb);
            #endregion

            #region second decision
            //if (firstNumb > secondNumb)
            //{
            //    Console.WriteLine("The result - {0} is greater than {1} -> {1} {0}", firstNumb, secondNumb);
            //}
            //else if (firstNumb < secondNumb)
            //{
            //    Console.WriteLine("The result - {1} is greater than {0 } -> {0} {1}", firstNumb, secondNumb);
            //}
            //else
            //{
            //    Console.WriteLine("{0} and {1} are equal", firstNumb, secondNumb);
            //}
            #endregion
        }
    }
}
