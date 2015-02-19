using System;

namespace BinarySearch
{
    class BinSearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="theKey"></param>
        /// <returns></returns>
        static int SearchBinary(int[] array, int theKey)
        {
            int rightSide = array.Length - 1;
            int leftSide = 0;

            while (rightSide >= leftSide)
            {
                int arrMiddle = (leftSide + rightSide) / 2;
                if (array[arrMiddle] < theKey)
                {
                    leftSide = arrMiddle + 1;
                }
                else if (array[arrMiddle] > theKey)
                {
                    rightSide = arrMiddle - 1;
                }
                else
                {
                    return arrMiddle;
                }
            }
            return -1;
        }

        static void Main()
        {
            int[] myArray = { 53, 34, 96, 9, 22, 11, 54, 17, 75, 44, 3, 8, 59, 65, 81,31 };
            Array.Sort(myArray);

            int theKey = 17;

            Console.WriteLine(SearchBinary(myArray, theKey));
        }
    }
}
