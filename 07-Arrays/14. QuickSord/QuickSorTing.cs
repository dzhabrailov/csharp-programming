﻿using System;
using System.Collections.Generic;

namespace QuickSord
{
    class QuickSorTing
    {
        /// <summary> Problem 14. Quick sort
        /// Write a program that sorts an array of integers using the Quick sort algorithm.
        /// </summary>
        static List<int> QuickSortEmpement(List<int> unsortedList)
        {
            if (unsortedList.Count <= 1)
            {
                return unsortedList;
            }
           
            int pivot = unsortedList.Count / 2;
            int pivotValue = unsortedList[pivot];
            unsortedList.RemoveAt(pivot);
           
            List<int> lesser = new List<int>();
            List<int> greater = new List<int>();
            foreach (int element in unsortedList)
            {
                if (element <= pivotValue)
                {
                    lesser.Add(element);
                }
                else
                {
                    greater.Add(element);
                }
            }
           
            List<int> result = new List<int>();
            result.AddRange(QuickSortEmpement(lesser));
            result.Add(pivotValue);
            result.AddRange(QuickSortEmpement(greater));
           
            return result;
        }
        static void Main()
        {
            List<int> myArray = new List<int> { 2, 3, 5, 0, 123, 3, 23, 1234, 87 };
            List<int> sortedArray = QuickSortEmpement(myArray);
            foreach (var item in sortedArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}