using System;

namespace FillTheMatrix
{
    class TheMatrix
    {
        /// <summary> Problem 01 Fill the matrix
        /// Write a program that fills and prints a matrix of size (n, n) as shown below:
        /// Example for n=4:
        /// </summary>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please select which of the following matrix you want to print: A, B or C");
                string choise = Console.ReadLine();

                CheckUserChoise(choise);
            }
        }

        /// <summary>
        /// Check matrix which user has chosen
        /// </summary>
        static void CheckUserChoise(string choise)
        {
            if (choise == "a" || choise == "A")
            {
                MatrixA();
            }
            else if (choise == "b" || choise == "B")
            {
                MatrixB();
            }
            else if (choise == "c" || choise == "C")
            {
                MatrixC();
            }
            return;
        }

        /// <summary> Matrix A
        /// 1 	5 	9 	13
        /// 2 	6 	10 	14
        /// 3 	7 	11 	15
        /// 4 	8 	12 	16
        /// </summary>
        static void MatrixA()
        {
            Console.Write("Enter size for matrix 'A': ");
            int inuptNumber = int.Parse(Console.ReadLine());

            int[,] matrix = new int[inuptNumber, inuptNumber];
            int count = 1;

            for (int cols = 0; cols < inuptNumber; cols++)
            {
                for (int rows = 0; rows < inuptNumber; rows++)
                {
                    matrix[rows, cols] = count++;
                }
            }
            for (int rows = 0; rows < inuptNumber; rows++)
            {
                for (int cols = 0; cols < inuptNumber; cols++)
                {
                    Console.Write("{0, -3}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        /// <summary> Matrix B
        /// 1 	8 	9 	16
        /// 2 	7 	10 	15
        /// 3 	6 	11 	14
        /// 4 	5 	12 	13
        /// </summary>
        static void MatrixB()
        {
            Console.Write("Enter size for matrix 'B': ");
            int inputNumber = int.Parse(Console.ReadLine());

            int[,] matrix = new int[inputNumber, inputNumber];
            int count = 1;
            int currentCount = 1;

            for (int cols = 0; cols < inputNumber; cols++)
            {
                for (int rows = 0; rows < inputNumber; rows++)
                {
                    if (cols % 2 == 0)
                    {
                        matrix[rows, cols] = count++;
                    }
                    else
                    {
                        matrix[rows, cols] = --count;
                    }
                }
                if (cols % 2 == 0)
                {
                    currentCount = count;
                    currentCount += inputNumber;
                    count = currentCount;
                }
                else
                {
                    count = currentCount;
                }
            }
            for (int rows = 0; rows < inputNumber; rows++)
            {
                for (int cols = 0; cols < inputNumber; cols++)
                {
                    Console.Write("{0, -3}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        /// <summary> Matrix C
        /// 7 	11 	14 	16
        /// 4 	8 	12 	15
        /// 2 	5 	9 	13
        /// 1 	3 	6 	10
        /// </summary>
        static void MatrixC()
        {
            Console.Write("Enter size for matrix 'C': ");
            int inputNumber = int.Parse(Console.ReadLine());

            int[,] matrix = new int[inputNumber, inputNumber];
            int rows = 0;
            int cols = 0;
            int value = 1;

            for (int i = inputNumber - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < inputNumber && cols < inputNumber)
                {
                    matrix[rows++, cols++] = value++;
                }
            }

            for (int j = 1; j < inputNumber; j++)
            {
                rows = j;
                cols = 0;
                while (rows < inputNumber && cols < inputNumber)
                {
                    matrix[cols++, rows++] = value++;
                }
            }

            for (rows = 0; rows < inputNumber; rows++)
            {
                for (cols = 0; cols < inputNumber; cols++)
                {
                    Console.Write("{0, -3}", matrix[rows, cols]);
                }

                Console.WriteLine();
            }
        }
    }
}
