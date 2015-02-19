using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class MoonGravity
    {
        static void Main()
        {
            //get user weight
            Console.WriteLine("What is your weight (kg)? ");
            double userWeight = double.Parse(Console.ReadLine());

            //moon gravity 17% => 17/100 = 0.17
            double moonGravity = 0.17;

            Console.WriteLine(userWeight * moonGravity);
        }
    }
}
