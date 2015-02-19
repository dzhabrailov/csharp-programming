using System;
using System.Linq;

namespace CompareArrays
{
    class ArrayComparer
    {
        /// <summary>
        /// Problem 2. Compare arrays
        /// Write a program that reads two integer arrays from the console and compares them element by element.
        /// </summary>
        static void Main()
        {
            while (true)
            {
                //set arrays lenght
                Console.Write("Set your arrays lenght: ");
                int inputNumber = int.Parse(Console.ReadLine());

                //declare arrays
                int[] firstArr = new int[inputNumber];
                int[] secondArr = new int[inputNumber];

                Console.WriteLine("First array: ");
                //initialize indexes - first array
                for (int i = 0; i < firstArr.Length; i++)
                {
                    Console.WriteLine("Push {0} element in first array: ", i);
                    firstArr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("Second array: ");
                //initialize indexes - second array
                for (int j = 0; j < secondArr.Length; j++)
                {
                    Console.WriteLine("Push {0} element in second array: ", j);
                    secondArr[j] = int.Parse(Console.ReadLine());
                }

                //sort the arrays
                Array.Sort(firstArr);
                Array.Sort(secondArr);

                bool areEqual = Enumerable.SequenceEqual(firstArr, secondArr);
                Console.WriteLine("The arrays are equal - {0}!", areEqual);
                Console.WriteLine();


                //second variant
                Console.WriteLine("Second variant: ");
                bool checkIsEqual = false;
                for (int index = 0; index < firstArr.Length; index++)
                {
                    if (firstArr[index] == secondArr[index])
                    {
                        checkIsEqual = true;
                        break;
                    }
                }
                Console.WriteLine("The arrays are equal - {0}!", checkIsEqual);
                Console.WriteLine();
            }
        }
    }
}
