using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ZeroSubset
{
    /// <summary> 12.* Zero Subset
    /// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    /// Assume that repeating the same subset several times is not a problem.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //define an array with 5 elements    
            int[] numbers = new int[5];     

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a [" + (i + 1) + "] number: ");
                //fill in array using for loop
                numbers[i] = Int32.Parse(Console.ReadLine()); 
            }

            // compare pairs {-1, 1}, {-2, 2} etc...
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        Console.WriteLine("The subset {" + numbers[i] + ", " + numbers[j] + "} is equal to 0.");
                    }
                }
            }

            // compare triples {-1, -1, 2}, {1, 2, -3} etc...
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i; j < numbers.Length - 2; j++)
                {
                    if (numbers[i] + numbers[j + 1] + numbers[j + 2] == 0)
                    {
                        Console.WriteLine("The subset {" + numbers[i] + ", " + numbers[j + 1] + ", " + numbers[j + 2] + "} is equal to 0.");
                    }
                }
            }

            // compare fours {-1, -1, -1, 3}, {1, -2, 3, -2} etc...
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                for (int j = i; j < numbers.Length - 3; j++)
                {
                    if (numbers[i] + numbers[j + 1] + numbers[j + 2] + numbers[j + 3] == 0)
                    {
                        Console.WriteLine("The subset {" + numbers[i] + ", " + numbers[j + 1] + ", " + numbers[j + 2] + ", " + numbers[j + 3] + "} is equal to 0.");
                    }
                }
            }
        }
    }
}
