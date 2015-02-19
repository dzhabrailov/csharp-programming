using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInfo
{
    class CompanyInfo
    {
        /// <summary> 2. Print Company Information
        ///     A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
        ///     Write a program that reads the information about a company and its manager and prints it back on the console.
        ///     Example input:
        ///     Company name: 	Telerik Academy
        ///     Company address: 	31 Al. Malinov, Sofia
        ///     Phone number: 	+359 888 55 55 555
        ///     Fax number: 	2
        ///     Web site: 	http://telerikacademy.com/
        ///     Manager first name: 	Nikolay
        ///     Manager last name: 	Kostov
        ///     Manager age: 	25
        ///     Manager phone: 	+359 2 981 981
        /// </summary>
        /// <param name="args"></param>

        static void Main()
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Enter company telephone number: ");
            string companyTelephoneNumber = Console.ReadLine();

            Console.Write("Enter company fax number: ");
            string companyFaxNumber = Console.ReadLine();

            Console.Write("Enter company website address: ");
            string companyWebsite = Console.ReadLine();

            Console.Write("Enter company manager person [first name]: ");
            string companyManagerFirstName = Console.ReadLine();

            Console.Write("Enter company manager person [last name]: ");
            string companyManagerLastName = Console.ReadLine();

            Console.Write("Enter Manager age: ");
            string managerAge = Console.ReadLine();

            Console.Write("Enter Manager telephone number: ");
            string managerTelephoneNumber = Console.ReadLine();
           
            Console.WriteLine();
            Console.WriteLine("{0} has address {1}, telephone numner: {2}\nFAX number: {3}\nWebsite: {4}\nManager for contact: {5}\nManager Age: {6}\nManager Contact number: {7}",
                companyName, companyAddress, companyTelephoneNumber, companyFaxNumber, companyWebsite,
                (companyManagerFirstName + " " + companyManagerLastName), managerAge, managerTelephoneNumber);
        }
    }
}
