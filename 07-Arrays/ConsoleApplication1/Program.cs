using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            #region
            ////set size of arrays
            //Console.Write("Set your arrays size: ");
            //char inputNumber = char.Parse(Console.ReadLine());

            ////declare arrays
            //char[] firstArr = new char[inputNumber];
            //char[] secondArr = new char[inputNumber];

            //Console.WriteLine("First array: ");
            ////initialize indexes - first array
            //for (int i = 0; i < firstArr.Length; i++)
            //{
            //    Console.WriteLine("Push {0} element in first array: ", i);
            //    firstArr[i] = char.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("Second array: ");
            ////initialize indexes - second array
            //for (int j = 0; j < secondArr.Length; j++)
            //{
            //    Console.WriteLine("Push {0} element in second array: ", j);
            //    secondArr[j] = char.Parse(Console.ReadLine());
            //}
            #endregion

            #region
            //int[] myArray = { 2, 1, 3, 2, 3, 3, 2, 2, 2, 1 };

            //int len = 1;
            //int bestLen = 0;
            //int bestLenElement = 0;
            //for (int i = 0; i < myArray.Length - 1; i++)
            //{
            //    if (myArray[i] == myArray[i + 1])
            //    {
            //        len++;
            //    }
            //    else
            //    {
            //        if (len > bestLen)
            //        {
            //            bestLen = len;
            //            bestLenElement = myArray[i];
            //        }
            //        len = 1;
            //    }
            //}
            //// Special case
            //if (len > bestLen)
            //{
            //    bestLen = len;
            //    bestLenElement = myArray[myArray.Length - 1];
            //}
            //Console.WriteLine("The longest sequence if form {0} elements of type \"{1}\" .", bestLen, bestLenElement);
            #endregion

            #region

            int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Dictionary<int, int> mostFrequnet = new Dictionary<int, int>();
           
            int bestElement = 0;
            int bestFrequnecy = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                int tempValue;
                if (mostFrequnet.TryGetValue(myArray[i], out tempValue))
                {
                    mostFrequnet[myArray[i]] = tempValue + 1;
                }
                else
                {
                    mostFrequnet.Add(myArray[i], 1);
                }
            }

            foreach (var item in mostFrequnet)
            {
                if (item.Value > bestFrequnecy)
                {
                    bestElement = item.Key;
                    bestFrequnecy = item.Value;
                }
            }
            Console.WriteLine("The number {0} shows {1} times", bestElement, bestFrequnecy);
            #endregion
        }
    }
}
