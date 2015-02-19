using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class PersonalData
    {
        /// <summary> Problem 10
        ///  Employee Data 
        ///  A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        ///  First name, Last name, Age (0...100), Gender (m or f), Personal ID number (e.g. 8306112507), Unique employee number (27560000…27569999)
        ///  Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
        ///  Use descriptive names. Print the data at the console.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Enter first name of the employee: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name of the employee: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age of the employee: ");
            string age = Console.ReadLine();
            if (int.Parse(age) <= 100)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("Invalid age");
                return;
            }
            Console.WriteLine("Enter gender of the employee ->(m/f): ");
            string gender = Console.ReadLine();
            if (gender == "m")
            {
                Console.WriteLine("Gender is \"M\"");
            }
            else if (gender == "f")
            {
                Console.WriteLine("Gender is \"F\"");
            }
            else
            {
                Console.WriteLine("Incorrect gender! Try again: (m/f)");
            }

            Console.WriteLine("Enter passport ID of the employee: ");
            int passportId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter personal ID of the employee between 27560000 and 27569999: ");
            int personalId = Int32.Parse(Console.ReadLine());
            if ((personalId < 27560000) || (personalId > 27569999))
            {
                Console.WriteLine("Invalid ID!");
            }
            else
            {
                Console.WriteLine("Correct ID!");
            }

            Console.WriteLine("\n \n \n");
            Console.WriteLine(">> Full name: {0} {1}\n>> Age: {2}\n>> Gender: {3}\n>> Passport ID: {4}\n>> Presonal ID: {5}", firstName, lastName, age, gender, passportId, personalId);
        }
    }
}
