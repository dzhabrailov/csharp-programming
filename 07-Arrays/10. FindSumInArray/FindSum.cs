using System;
using System.Text;

namespace FindSumInArray
{
    class FindSum
    {
        /// <summary> Problem 10. Find sum in array
        /// Write a program that finds in given array of integers a sequence of given sum S (if present).
        /// Example:
        /// Array                |  Sum  |  Result
        /// 4, 3, 1, 4, 2, 5, 8  |  11   |  4, 2, 5
        /// </summary>
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int[] myArray = { 4, 3, 1, 4, 2, 5, 8 };
          
            string sequence = "";
            StringBuilder sequenceBuild = new StringBuilder();
            for (int i = 0; i < myArray.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < myArray.Length; j++)
                {
                    sum = sum + myArray[j];
                    sequenceBuild.AppendFormat("{0}, ", myArray[j]);
                    if (sum > s)
                    {
                        sequenceBuild.Clear();
                        sum = 0;
                        break;
                    }
                    if (sum == s)
                    {
                        sequence = sequenceBuild.ToString();
                        Console.WriteLine("This sequence has the sum of {0} : {1}", s, sequence);
                    }
                }
            }
        }
    }
}
