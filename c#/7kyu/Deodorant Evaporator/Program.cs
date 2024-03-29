﻿using System;

namespace Deodorant_Evaporator
{
    class Program
    {
        // https://www.codewars.com/kata/deodorant-evaporator/train/csharp
        
        // This program tests the life of an evaporator containing a gas.
        //
        // We know the content of the evaporator (content in ml), the percentage of foam
        // or gas lost every day (evap_per_day) and the threshold (threshold) in percentage
        // beyond which the evaporator is no longer useful. All numbers are strictly positive.
        //
        // The program reports the nth day (as an integer) on which the evaporator will be out of use.
        //
        // Note : Content is in fact not necessary in the body of the function "evaporator",
        // you can use it or not use it, as you wish. Some people might prefer to reason with content,
        // some other with percentages only. It's up to you but you must keep it as a
        // parameter because the tests have it as an argument.
        static void Main(string[] args)
        {
            Console.WriteLine(Evaporator(10, 10, 10));
        }
        
        public static int Evaporator(double content, double evap_per_day, double threshold)
        {
            var days = 0;
            double sprayContent = 100;
            while (sprayContent > threshold)
            {
                days++;
                sprayContent -= (sprayContent * evap_per_day * 0.01);
            }

            return days;
        }
    }
}
