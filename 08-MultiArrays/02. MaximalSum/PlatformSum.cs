using System;

namespace MaximalSum
{
    class PlatformSum
    {
        /// <summary> Problem 2. Maximal sum
        /// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
        /// </summary>
        static void Main()
        {
            #region read from the console
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n, m];
            //for (int row = 0; row < arr.GetLength(0); row++)
            //{
            //    for (int col = 0; col < arr.GetLength(1); col++)
            //    {
            //        arr[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}
            #endregion

            int[,] arr = new int[,]{{1,2,3,4}, {5,6,7,8}, {9,8,7,6}, {5,4,3,2}, {1,0,9,8}};
           
            int maxSum = int.MinValue;
            int sum = 0;
            int startIndexRowMaxSum = 0;
            int startIndexColMaxSum = 0;
         
            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 2; col++)
                {
                    sum += arr[row, col] + arr[row, col + 1] + arr[row, col + 2] +
                        arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] +
                        arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startIndexRowMaxSum = row;
                        startIndexColMaxSum = col;
                    }
                    sum = 0;
                }
            }

            Console.WriteLine("Max Sum is: {0}", maxSum);
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0,3} ", arr[startIndexRowMaxSum, startIndexColMaxSum]);
                    startIndexColMaxSum++;
                }
                startIndexColMaxSum -= 3;
                startIndexRowMaxSum++;
                Console.WriteLine();
            }
        }
    }
}
