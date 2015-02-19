using System;
using System.Linq;

namespace ComapreCharArray
{
    class CharComparer
    {
        /// <summary>
        /// Problem 3. Compare char arrays
        /// Write a program that compares two char arrays lexicographically (letter by letter).
        /// </summary>
        static void Main()
        {
            while (true)
            {
                //set lenght of arrays
                Console.Write("Set your arrays size: ");
                int inputNumber = int.Parse(Console.ReadLine());

                //declare arrays
                char[] firstArray = new char[inputNumber];
                char[] secondArray = new char[inputNumber];

                Console.WriteLine("First array: ");
                //initialize indexes - first array
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.WriteLine("Push {0} element in first array: ", i);
                    firstArray[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("Second array: ");
                //initialize indexes - second array
                for (int j = 0; j < secondArray.Length; j++)
                {
                    Console.WriteLine("Push {0} element in second array: ", j);
                    secondArray[j] = char.Parse(Console.ReadLine());
                }

                bool areLexicographically = true;

                if (firstArray.Length == secondArray.Length)
                {
                    for (int i = 0; i < firstArray.Length; i++)
                    {
                        if (firstArray[i] != secondArray[i])
                        {
                            areLexicographically = false;
                            break;
                        }
                    }
                    Console.WriteLine(areLexicographically);
                }
                else
                {
                    Console.WriteLine(areLexicographically);
                }
            }
        }
    }
}
