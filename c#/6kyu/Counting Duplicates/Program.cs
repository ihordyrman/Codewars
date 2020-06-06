using System;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Duplicates
{
    class Program
    {
        // https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp
        
        // Count the number of Duplicates
        // Write a function that will return the count of distinct case-insensitive
        // alphabetic characters and numeric digits that occur more than once in the input string.
        // The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
        
        // Example
        // "abcde" -> 0 # no characters repeats more than once
        // "aabbcde" -> 2 # 'a' and 'b'
        // "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
        // "indivisibility" -> 1 # 'i' occurs six times
        // "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
        // "aA11" -> 2 # 'a' and '1'
        // "ABBA" -> 2 # 'A' and 'B' each occur twice
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("aabbcde"));
            Console.WriteLine(DuplicateCount("aabBcde"));
            Console.WriteLine(MuchCleverDuplicateCount("abcde"));
            Console.WriteLine(MuchCleverDuplicateCount("Indivisibility"));
            Console.WriteLine(DuplicateCount(""));
        }

        private static int DuplicateCount(string str)
        {
            var chars = new Dictionary<char, int>();
            foreach (var t in str.ToLower())
            {
                if (chars.ContainsKey(t)) chars[t]++;
                else chars.Add(t, 0);
            }
            
            return chars.Select(x => x.Value).Count(x => x > 0);
        }

        private static int MuchCleverDuplicateCount(string str)
        {
            return str.ToLower().GroupBy(x => x).Count(y => y.Count() > 1);
        }
    }
}
