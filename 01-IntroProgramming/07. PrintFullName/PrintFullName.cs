using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFullName
{
    class PrintFullName
    {
        static void Main()
        {
            Console.Write("What's your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name: ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your full name is: {0}", fullName);
        }
    }
}
