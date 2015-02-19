using System;
using System.Linq;
using System.Collections.Generic;

namespace SortString
{
    class SortByLenght
    {
        /// <summary> Problem 5. Sort by string length
        /// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
        /// </summary>
        static void Main()
        {
            string[] input = { "stegosaurus", "piranha", "leopard", "cat", "bear", "hyena", "apple", "horse", "tomato", "carrot", "cucumber", "duck" };

            IEnumerable<string> someStrings = from symbol in input
                                        orderby symbol.Length
                                        select symbol;
            foreach (string str in someStrings)
            { 
                Console.WriteLine(str);
            }
        }
    }
}
