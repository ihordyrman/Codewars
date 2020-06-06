using System;
using System.Collections.Generic;
using System.Linq;

namespace Consecutive_strings
{
    // https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp

    // You are given an array strarr of strings and an integer k.
    // Your task is to return the first longest string consisting of k consecutive strings taken in the array.

    // Example:
    // longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"
    // n being the length of the string array, if n = 0 or k > n or k <= 0 return "".
    // Note: consecutive strings : follow one after another without an interruption
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsec(new[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 3));
            Console.WriteLine(LongestConsec(new[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1));
            Console.WriteLine(LongestConsec(new[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2));
            Console.WriteLine(LongestConsec(new string[] { }, 3), "");
            Console.WriteLine(LongestConsec(new[] {"itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck"}, 2));
            Console.WriteLine(LongestConsec(new[] {"wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu"}, 2));
            Console.WriteLine(LongestConsec(new[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2));
            Console.WriteLine(LongestConsec(new[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2), "");
            Console.WriteLine(LongestConsec(new[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 15));
            Console.WriteLine(LongestConsec(new[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 0));
        }

        private static string LongestConsec(string[] strarr, int k)
        {
            if (k <= 0 || strarr.Length == 0 || strarr.Length < k) return "";
            var max = strarr.Distinct()
                .GroupBy(r => r.Length)
                .Select(x => x.OrderBy(z => z).First())
                .OrderByDescending(s => s.Length)
                .Take(k)
                .ToArray();

            return strarr.Distinct().Where(s => max.Contains(s)).Aggregate("", (current, s) => current + s);
        }
    }
}