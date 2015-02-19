using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideChecker
    {
        /// <summary>
        /// Problem 3. Divide by 7 and 5
        /// Write a Boolean expression that checks for given integer if it can be divided (without remainder)
        /// by 7 and 5 at the same time.Examples:
        /// n 	Divided by 7 and 5?
        /// 3 	false
        /// 0 	false
        /// 5 	false
        /// 7 	false
        /// 35 	true
        /// 140 true
        /// </summary>
        static void Main()
        {
            bool isDivide = true;

            Console.WriteLine("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            if ((inputNumber % 5 == 0) && (inputNumber % 7 == 0))
            {
                Console.WriteLine(isDivide);
            }
            else 
            {
                Console.WriteLine(!isDivide);
            }
        }
    }
}
