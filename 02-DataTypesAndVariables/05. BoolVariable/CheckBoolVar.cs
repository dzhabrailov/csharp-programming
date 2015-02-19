using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVariable
{
    class CheckBoolVar
    {
        /// <summary> Problem 5
        /// Boolean Variable  
        /// Declare a Boolean variable called isFemale and assign an 
        /// appropriate value corresponding to your gender. Print it on the console.
        /// </summary>
        static void Main()
        {
            bool isFemale = false;

            Console.WriteLine("Is your gender is female?");
            Console.WriteLine("Enter your choose: Male(m) or Female(f)?");
            string choose = Console.ReadLine();

            if (choose == "Female" || choose == "female" || choose == "f" || choose == "F")
            {
                //isFemale is true when your gender is female
                Console.WriteLine(!isFemale);
            }
            else if (choose == "Male" || choose == "male" || choose == "m" || choose == "M")
            {
                //false when your gender is different of female
                Console.WriteLine(isFemale);
            }
            else
            {
                Console.WriteLine("Your choice is not correct! Try again! Male or Female?");
            }
        }
    }
}
