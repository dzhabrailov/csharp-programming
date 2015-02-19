using System;

namespace MaximalKSum
{
    class SumOfK
    {
        /// <summary>
        /// Problem 6. Maximal K sum
        /// Write a program that reads two integer numbers N and K and an array of N elements from the console.
        /// Find in the array those K elements that have maximal sum.
        /// </summary>
        static void Main()
        {
            // input
            int inputN = int.Parse(Console.ReadLine());
            int inputK = int.Parse(Console.ReadLine());
            
            int[] myArray = new int[inputN];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            
            string bestSeq = "";
            int sum = 0;
            int bestSum = int.MinValue;
            int myArrayLenght = myArray.Length;
            for (int i = 0; i < myArrayLenght; i++)
            {
                string currentSeq = "";
                // checking for out of range
                if (myArrayLenght < inputK+i)
                {
                    break;
                }
                // set check
                for (int j = i; j < inputK + i; j++)
                {
                    sum = sum + myArray[j];
                    currentSeq = currentSeq + ' ' + myArray[j];
                }
                // best sum check
                if (sum > bestSum)
                {
                    bestSeq = currentSeq;
                    bestSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine(bestSeq);
            Console.WriteLine(bestSum);
        }
    }
}
