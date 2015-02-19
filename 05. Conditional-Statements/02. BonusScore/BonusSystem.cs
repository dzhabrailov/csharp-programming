using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusSystem
    {
        /// <summary> 2. Bonus Score
        /// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        /// If the score is between 1 and 3, the program multiplies it by 10.
        /// If the score is between 4 and 6, the program multiplies it by 100.
        /// If the score is between 7 and 9, the program multiplies it by 1000.
        /// If the score is 0 or more than 9, the program prints “invalid score”.
        /// Examples:
        /// score 	result
        /// 2 	    20
        /// 4 	    400
        /// 9 	    9000
        /// -1 	    invalid score
        /// 10 	    invalid score
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    points *= 10;
                    Console.WriteLine("You have a {0} points", points);
                    break;
                case 4:
                case 5:
                case 6:
                    points *= 100;
                    Console.WriteLine("You have a {0} points", points);
                    break;
                case 7:
                case 8:
                case 9:
                    points *= 1000;
                    Console.WriteLine("You have a {0} points", points);
                    break;
                default:
                    Console.WriteLine("Error! Invalid input! Please try again");
                    break;
            }
        }
    }
}
