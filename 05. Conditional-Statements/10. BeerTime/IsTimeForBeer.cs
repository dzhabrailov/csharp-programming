﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerTime
{
    /// <summary> 10.* Beer Time
    /// A beer time is after 1:00 PM and before 3:00 AM.
    /// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
    /// according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
    /// </summary>
    class IsTimeForBeer
    {
        static void Main()
        {
            Console.WriteLine("What time is it now? How do you think that it's time for a beer? ");
            DateTime beerTime = DateTime.Parse(Console.ReadLine());
            string sign = beerTime.ToString("tt");

            if (beerTime.Hour < 12)
            {
                if (sign == "AM" && sign == "am")
                {
                    if (beerTime.Hour >= 3 && beerTime.Minute >= 0 && beerTime.Minute < 60)
                    {
                        Console.WriteLine("Sorry bro! Not now!");
                    }
                    else
                    {
                        Console.WriteLine("Yes it's time! Grab one and cheers bro!");
                    }
                }
            }
            else
            {
                if (beerTime.Hour - 12 >= 1)
                {
                    Console.WriteLine("Yes it's time! Grab one and cheers bro!");
                }
                else
                {
                    Console.WriteLine("Sorry bro! Not now!");
                }
            }
        }
    }
}
