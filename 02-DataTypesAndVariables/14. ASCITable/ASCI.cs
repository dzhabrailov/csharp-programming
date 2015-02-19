﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCITable
{
    class ASCI
    {
        /// <summary> Problem 14
        ///  Print the ASCII Table:
        ///  Find online more information about ASCII (American Standard Code for Information Interchange) 
        ///  and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
        /// </summary>
        static void Main()
        {
            for (int i = 0; i < 255; i++)
            {
                char symbol = (char)i;
                Console.WriteLine("Number {0} = {1} in ASCI", i, symbol);
            }
        }
    }
}
