using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After10Years
{
    class CalculateAge
    {
        static void Main()
        {
            Console.WriteLine("Enter your B-Day /yyyy, mm, dd/");

            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime currentDate = DateTime.Now;

            int userAge = currentDate.Year - birthDay.Year;
            if (currentDate < birthDay.AddYears(userAge))
            {
                userAge--;
            }

            int calculateAge = userAge + 10;
            Console.WriteLine("You are {0} years old.", userAge);
            Console.WriteLine("After ten years your age will be {0}.", calculateAge);

            
            //Console.WriteLine("What's your age?");
            //int age = int.Parse(Console.ReadLine());
            //int calculateAge = age + 10;
            //Console.WriteLine("After ten years your age will be " + calculateAge);
        }
    }
}
