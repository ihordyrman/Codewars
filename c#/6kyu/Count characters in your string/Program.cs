using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_characters_in_your_string
{
    class Program
    {
        // https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp

        // The main idea is to count all the occurring characters(UTF-8) in string.
        // If you have string like this aba then the result should be { 'a': 2, 'b': 1 }
        // What if the string is empty? Then the result should be empty object literal { }
        // For C#: Use a Dictionary<char, int> for this kata!

        static void Main(string[] args)
        {
            var a = Count("aaaa");
            var b = BetterCount("aabb");
        }

        public static Dictionary<char, int> Count(string str)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i])) dict.Add(str[i], 1);
                else dict[str[i]]++;
            }

            return dict;
        }

        public static Dictionary<char, int> BetterCount(string str)
        {
            return str.GroupBy(c => c).ToDictionary(x => x.Key, y => y.Count());
        }
    }
}
