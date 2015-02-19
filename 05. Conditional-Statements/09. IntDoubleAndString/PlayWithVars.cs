using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleAndString
{
    /// <summary> 9. Play with Int, Double and String
    /// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    /// If the variable is int or double, the program increases it by one.
    /// If the variable is a string, the program appends * at the end.
    /// Print the result at the console. Use switch statement.
    /// </summary>
    class PlayWithVars
    {
        static void Main()
        {
            Console.Write("Enter something [int, double or string]: ");

            string userInput = Console.ReadLine();

            int userInputInt;        //  1
            double userInputDouble;  //  2

            int tempVar = 0;

            if (Int32.TryParse(userInput, out userInputInt))
            {
                tempVar = 1; // assign tempVar = 1 if userInput is integer number
                userInputInt = Int32.Parse(userInput);
            }

            if (double.TryParse(userInput, out userInputDouble))
            {
                tempVar = 2; // assign tempVar = 2 if userInput is real number
                userInputDouble = double.Parse(userInput);
            }

            switch (tempVar)
            {
                case 1:
                    userInputInt++;
                    Console.WriteLine(userInputInt);
                    break;
                case 2:
                    userInputDouble++;
                    Console.WriteLine(userInputDouble);
                    break;
                default:
                    Console.WriteLine(userInput + "*");
                    break;
            }
        }
    }
}
