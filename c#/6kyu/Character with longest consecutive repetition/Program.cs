using System;
using System.Collections.Generic;
using System.Linq;

namespace Character_with_longest_consecutive_repetition
{
    class Program
    {
        /*
         * Character with longest consecutive repetition
         * https://www.codewars.com/kata/586d6cefbcc21eed7a001155/train/csharp
         *
         * For a given string s find the character c (or C) with longest consecutive repetition and return:
         * Tuple<char?, int>(c, l)
         * where l (or L) is the length of the repetition. If there are two or more characters with the same l return the first in order of appearance.
         * For empty string return:
         * Tuple<char?, int>(null, 0)
         */
        static void Main(string[] args)
        {
            Console.WriteLine(LongestRepetition("aaaabb"));
            Console.WriteLine(LongestRepetition("abbbbb"));
            Console.WriteLine(LongestRepetition("bbbaaabaaaa"));
            Console.WriteLine(LongestRepetition("cbdeuuu900"));
            Console.WriteLine(LongestRepetition("ba"));
            Console.WriteLine(LongestRepetition("aabb"));
            Console.WriteLine(LongestRepetition(""));
        }

        private static Tuple<char?, int> LongestRepetition(string input)
        {
            if (input == string.Empty)
                return new Tuple<char?, int>(null, 0);

            var results = new List<Tuple<char?, int>>();
            var current = new Tuple<char?, int>(input[0], 1);

            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] == current.Item1)
                {
                    var ch = current.Item1;
                    var count = current.Item2 + 1;
                    current = new Tuple<char?, int>(ch, count);
                }
                else
                {
                    results.Add(current);
                    current = new Tuple<char?, int>(input[i], 1);
                }
            }

            results.Add(current);
            return results.OrderByDescending(x => x.Item2).First();
        }
    }
}