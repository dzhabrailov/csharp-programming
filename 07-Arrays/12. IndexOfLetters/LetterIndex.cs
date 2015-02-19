using System;

namespace IndexOfLetters
{
    /// <summary> Problem 12. Index of letters
    /// Write a program that creates an array containing all letters from the alphabet (A-Z).
    /// Read a word from the console and print the index of each of its letters in the array.
    /// </summary>
    class LetterIndex
    {
        static void Main()
        {
            int[] letterIndexes = new int[53];
            //lowercase
            for (int i = 1; i < letterIndexes.Length / 2 + 1; i++)
            {
                letterIndexes[i] = ('a' - 1) + i;
            }
            
            //Upercase
            for (int i = letterIndexes.Length / 2 + 1, k = 0; i < letterIndexes.Length; i++, k++)
            {
                letterIndexes[i] = 'A' + k;
            }
          
            //Letter chercker
            string intpuWord = "Telerik Academy";
            for (int i = 0; i < intpuWord.Length; i++)
            {
                for (int j = 0; j < letterIndexes.Length; j++)
                {
                    if (intpuWord[i] == letterIndexes[j])
                    {
                        Console.WriteLine("Leter {0} has index: {1}", intpuWord[i], j);
                        break;
                    }
                }
            }
        }
    }
}
