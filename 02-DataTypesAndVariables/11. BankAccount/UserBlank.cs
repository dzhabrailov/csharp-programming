using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class UserBlank
    {
        /// <summary> Problem 11
        /// Bank Account Data
        /// A bank account has a holder name (first name, middle name and last name), 
        /// available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
        /// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
        /// </summary>
        static void Main()
        {
            string firstName = "Firstname";
            string fatherName = "Fathername";
            string lastName = "Lastname";
            object userFullName = firstName + " " + fatherName + " " + lastName;

            decimal balance = 123456789.99M;
            string bankName = "AnY Bank";
            string BIC = "963852741";
            string IBAN = "BGSF123456789";
            string debitCard = "1234 5678 9876 5432 100";
            string debitCard2 = "1234 5678 9876 5432 101";
            string creditCard = "1234 5678 9876 5432 102";
            object userAccount = "Bank >> " + bankName + "\n" + "BIC >> " + BIC + "\n" + "IBAN >> " + IBAN + "\n" + "Primary debit card >> " + debitCard + "\n" + "Secondary debit card >> " + debitCard2 + "\n" + "Credit card >> " + creditCard + "\n" + "Account balance >> " + balance.ToString();


            Console.WriteLine("***************** CLIENT ACCOUNT *****************");
            Console.WriteLine(userFullName);
            Console.WriteLine(userAccount);
        }
    }
}
