using System;

namespace SelectionSort
{
    class SortingArray
    {
        /// <summary> Problem 7. Selection sort
        /// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        /// Use the Selection sort algorithm: Find the smallest element, move it at the first position,
        /// find the smallest from the rest, move it at the second position, etc.
        /// </summary>
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] shuffleArray = new int[inputNumber];

            for (int i = 0; i < shuffleArray.Length; i++)
            {
                shuffleArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < shuffleArray.Length - 1; i++)
            {
                for (int j = i + 1;  j < shuffleArray.Length; j++)
                {
                    if (shuffleArray[i] > shuffleArray[j]) 
                    {
                        int temp = shuffleArray[i];
                        shuffleArray[i] = shuffleArray[j];
                        shuffleArray[j] = temp;
                    }
                }
            }
            
            string sortetArray = string.Join(" ", shuffleArray);
            Console.Write(sortetArray);
            Console.WriteLine();
        }
    }
}
