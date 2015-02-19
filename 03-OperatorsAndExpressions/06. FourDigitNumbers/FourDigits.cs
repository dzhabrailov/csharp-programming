using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumbers
{
    class FourDigits
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number % 10;

            int restNumberTwo = number / 10;
            int secondDigit = restNumberTwo % 10;

            int restNumberThree = number / 100;
            int thirdDigit = restNumberThree % 10;

            int restNumberFour = number / 1000;
            int fourthDigit = restNumberFour % 10;

            int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine("Number " + number);
            Console.WriteLine("Digits sum is " + sumOfDigits);
            Console.WriteLine("Reversed {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("Last digit {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
    }
}
