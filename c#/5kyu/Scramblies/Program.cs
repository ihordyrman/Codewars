using System;
using System.Linq;

namespace Scramblies
{
    class Program
    {
        // https://www.codewars.com/kata/55c04b4cc56a697bb0000048
        // Complete the function scramble(str1, str2) that returns true
        // if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

        // Notes:
        // Only lower case letters will be used (a-z). No punctuation or digits will be included.
        // Performance needs to be considered

        // Input strings s1 and s2 are null terminated.
        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("rkqodlw", "world")); // true
            Console.WriteLine(Scramble("cedewaraaossoqqyt", "codewars")); // true
            Console.WriteLine(Scramble("katas", "steak")); // false
            Console.WriteLine(Scramble("scriptjavx", "javascript")); // false
            Console.WriteLine(Scramble("scriptingjava", "javascript")); // true
            Console.WriteLine(Scramble("scriptsjava", "javascripts")); // true
            Console.WriteLine(Scramble("javscripts", "javascript")); // false
            Console.WriteLine(ScrambleLinq("aabbcamaomsccdd", "commas")); // true
            Console.WriteLine(ScrambleLinq("commas", "commas")); // true
            Console.WriteLine(ScrambleLinq("sammoc", "commas")); // true
        }

        private static bool Scramble(string str1, string str2)
        {
            if (str1.Length < str2.Length) return false;

            foreach (var c in str2)
            {
                if (!str1.Contains(c)) return false;
                var index = str1.IndexOf(c);
                str1 = str1.Remove(index, 1);
            }

            return true;
        }

        private static bool ScrambleLinq(string str1, string str2) =>
            str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
    }
}


// str1 = string.Join("", str1.Select(x => x).Where(x => str2.Contains(x)).OrderBy(x => x));
// str2 = string.Join("", str2.Select(x => x).OrderBy(x => x));