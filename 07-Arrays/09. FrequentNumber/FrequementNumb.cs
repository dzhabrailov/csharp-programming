using System;
using System.Collections.Generic;

namespace FrequentNumber
{
    class FrequementNumb
    {
        /// <summary> Problem 9. Frequent number 
        /// Write a program that finds the most frequent number in an array.
        /// Example:
        /// input 	                                |   result
        /// 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	|   4 (5 times)
        /// </summary>
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] myArray = new int[inputNumber];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> frequentNumber = new Dictionary<int, int>();
            int bestElement = 0;
            int bestFrequnecy = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                int tempValue;
                if (frequentNumber.TryGetValue(myArray[i], out tempValue))
                {
                    frequentNumber[myArray[i]] = tempValue + 1;
                }
                else
                {
                    frequentNumber.Add(myArray[i], 1);
                }
            }

            foreach (var item in frequentNumber)
            {
                if (item.Value > bestFrequnecy)
                {
                    bestElement = item.Key;
                    bestFrequnecy = item.Value;
                }
            }
            Console.WriteLine("The number {0} shows {1} times", bestElement, bestFrequnecy);
        }
    }
}
