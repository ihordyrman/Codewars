using System;
using System.Collections.Generic;
using System.Linq;

namespace Most_Frequent_Weekdays
{
    /*
        Most Frequent Weekdays
        https://www.codewars.com/kata/56eb16655250549e4b0013f4/train/csharp
    */
    internal static class Program
    {
        private static void Main()
        {
            DisplayArray(MostFrequentDays(2016));
            DisplayArray(MostFrequentDays(1770));
            DisplayArray(MostFrequentDays(2001));
            DisplayArray(MostFrequentDays(1968));
            DisplayArray(MostFrequentDays(1785));
            DisplayArray(MostFrequentDays(1910));
            DisplayArray(MostFrequentDays(2135));
            DisplayArray(MostFrequentDays(3043));
            DisplayArray(CleverMostFrequentDays(3150));
            DisplayArray(CleverMostFrequentDays(3361));
            DisplayArray(CleverMostFrequentDays(1901));
            DisplayArray(CleverMostFrequentDays(3230));
        }

        private static void DisplayArray(string[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");

            Console.WriteLine();
        }

        private static string[] MostFrequentDays(int year)
        {
            var date = new DateTime(year, 1, 1);
            var dic = new Dictionary<DayOfWeek, int>
            {
                { DayOfWeek.Monday, 0 },
                { DayOfWeek.Tuesday, 0 },
                { DayOfWeek.Wednesday, 0 },
                { DayOfWeek.Thursday, 0 },
                { DayOfWeek.Friday, 0 },
                { DayOfWeek.Saturday, 0 },
                { DayOfWeek.Sunday, 0 }
            };

            while (date.Year == year)
            {
                dic[date.DayOfWeek]++;
                date = date.AddDays(1);
            }

            int max = dic[0];
            int count = 0;

            foreach (var item in dic)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    count = 1;
                    continue;
                };

                if (item.Value == max) count++;
            }

            string[] result = new string[count];
            count = 0;

            foreach (var item in dic)
            {
                if (item.Value == max)
                {
                    result[count] = item.Key.ToString();
                    count++;
                }
            }

            return result;
        }

        private static string[] CleverMostFrequentDays(int year) {
            DateTime dt = new DateTime(year, 1, 1);
            return 
                DateTime.IsLeapYear(year) 
                ? (new[] { dt.DayOfWeek, dt.AddDays(1).DayOfWeek })
                    .OrderBy(dw => dw == DayOfWeek.Sunday 
                        ? 7 
                        : (int)dw).Select(dw => dw.ToString()).ToArray()
                : new[] { dt.DayOfWeek.ToString() };
        }
    }
}