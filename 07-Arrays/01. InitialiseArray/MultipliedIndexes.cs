using System;

namespace InitialiseArray
{
    class MultipliedIndexes
    {
        /// <summary>
        /// Problem 1. Allocate array
        /// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        /// Print the obtained array on the console.
        /// </summary>
        static void Main()
        {
            int[] initialArray = new int[20];

            Console.Write("Indexes that multiplied by 5 ->> ");
            for (int i = 0; i < initialArray.Length; i++)
            {
                initialArray[i] = i;
                if ((i % 5 == 0) && (i != 0))
                {
                    Console.Write(initialArray[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
