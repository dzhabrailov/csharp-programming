using System;
using System.Text;

namespace MaximalSum
{
    class MaxSum
    {
        /// <summary> Problem 8. Maximal sum
        /// Write a program that finds the sequence of maximal sum in given array.
        /// Example:
        /// input 	                          |  result
        /// 2, 3, -6, -1, 2, -1, 6, 4, -8, 8  |  2, -1, 6, 4
        /// </summary>
        static void Main()
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            int[] myArray = new int[inputNumbers];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int currentSum = 0;
            int bestSum = int.MinValue;
            StringBuilder bestSequenceBuild = new StringBuilder();
            string bestSequnce = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                currentSum = currentSum + myArray[i];
                bestSequenceBuild.AppendFormat("{0}, ", myArray[i]);
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestSequnce = bestSequenceBuild.ToString();
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                    bestSequenceBuild.Clear();
                }
            }
            Console.WriteLine("The best sequence is: \" {0} \" ", bestSequnce);
            Console.WriteLine("The best sum is: {0} ", bestSum);
        }
    }
}
