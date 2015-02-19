using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAsWords
{
    class NumbsAsWords
    {
        /// <summary> 11. Number as Words
        /// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation
        /// </summary>
        static void Main()
        {
            Console.Write("Enter number [1-999]: ");
            int number = int.Parse(Console.ReadLine());
         
            if (number <= 999 && number > 0)
            {
                switch (number / 100)
                {
                    case 0:
                        break;
                    case 1: Console.Write("one hundred");
                        break;
                    case 2: Console.Write("two hundred");
                        break;
                    case 3: Console.Write("tree hundred");
                        break;
                    case 4: Console.Write("four hundred");
                        break;
                    case 5: Console.Write("five hundred");
                        break;
                    case 6: Console.Write("six hundred");
                        break;
                    case 7: Console.Write("seven hundred");
                        break;
                    case 8: Console.Write("eight hundred");
                        break;
                    case 9: Console.Write("nine hundred");
                        break;
                    default: break;
                }
                if (number % 100 != 0 && number / 100 != 0)
                {
                    Console.Write("and ");
                }
                switch (number / 10 % 10)
                {
                    case 0:
                        break;
                    case 1:
                        switch (number % 10)
                        {
                            case 0: Console.Write("ten ");
                                break;
                            case 1: Console.Write("eleven ");
                                break;
                            case 2: Console.Write("twelve ");
                                break;
                            case 3: Console.Write("thirteen ");
                                break;
                            case 4: Console.Write("fourteen ");
                                break;
                            case 5: Console.Write("fiveteen ");
                                break;
                            case 6: Console.Write("sixteen ");
                                break;
                            case 7: Console.Write("seventeen ");
                                break;
                            case 8: Console.Write("eighteen ");
                                break;
                            case 9: Console.Write("nineteen ");
                                break;
                            default:
                                break;
                        }
                        break;

                    case 2: Console.Write("twenty ");
                        break;
                    case 3: Console.Write("thirty ");
                        break;
                    case 4: Console.Write("forty ");
                        break;
                    case 5: Console.Write("fifty ");
                        break;
                    case 6: Console.Write("sixty ");
                        break;
                    case 7: Console.Write("seventy ");
                        break;
                    case 8: Console.Write("eighty ");
                        break;
                    case 9: Console.Write("ninety ");
                        break;
                    default:
                        break;
                }
                switch (number % 10)
                {
                    case 0: if (number == 0)
                        {
                            Console.Write("zero");
                        }
                        Console.Write("\n ");
                        break;
                    case 1: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("one");
                        break;
                    case 2: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("two");
                        break;
                    case 3: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("three ");
                        break;
                    case 4: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("four");
                        break;
                    case 5: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("five");
                        break;
                    case 6: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("six");
                        break;
                    case 7: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("seven");
                        break;
                    case 8: if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("eight");
                        break;
                    case 9: if (number / 10 % 10 == 1)
                            break;
                        if (number / 10 % 10 == 1)
                            break;
                        Console.WriteLine("nine");
                        break;
                    default:
                        break;
                }
            }
            else Console.WriteLine("Fatal Error! :] ");
        }
    }
}
