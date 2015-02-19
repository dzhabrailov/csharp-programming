using System;

namespace IncreasingSequence
{
    class Increasing
    {
        /// <summary>
        /// Problem 5. Maximal increasing 
        /// Write a program that finds the maximal increasing sequence in an array.
        /// </summary>
        static void Main()
        {
            while (true)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                int[] myArray = new int[inputNumber];
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i]= int.Parse(Console.ReadLine());
                }

                int len = 1;
                int bestLen = 0;
                int endIndex = 0;
                
                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    if (myArray[i] < myArray[i + 1])
                    {
                        len++;
                    }
                    else
                    {
                        if (len > bestLen)
                        {
                            bestLen = len;
                            endIndex = i;
                        }
                        len = 1;
                    }
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    endIndex = myArray.Length - 1;
                }

                len = 1;
                Console.WriteLine("The longest sequence of increasing elemints is:");
                Console.Write("{");
                for (int i = endIndex - bestLen + 1; i < endIndex + 1; i++)
                {
                    Console.Write("{0},", myArray[i]);
                }
                Console.WriteLine("}");
            }
        }
    }
}
