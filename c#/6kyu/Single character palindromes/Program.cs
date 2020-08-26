using System;

namespace Single_character_palindromes
{
    /*
     * https://www.codewars.com/kata/5a2c22271f7f709eaa0005d3
     * Single character palindromes
     *
     * You will be given a string and you task is to check if it is possible
     * to convert that string into a palindrome by removing a single character.
     * If the string is already a palindrome, return "OK".
     * If it is not, and we can convert it to a palindrome by removing one character,
     * then return "remove one", otherwise return "not possible".
     * The order of the characters should not be changed.
     */
    internal static class Program
    {
        private static void Main()
        {
            // check if palindrome
            Console.WriteLine(Solve("abba")); // OK
            Console.WriteLine(Solve("abbaa")); // remove one
            Console.WriteLine(Solve("abbaab")); // not possible
        }

        private static string Solve(string s)
        {
            if (string.IsNullOrEmpty(s)) return "not possible";

            for (var i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - 1 - i]) continue;
                if (s.Length % 2 == 0) return "not possible";

                // todo: check if it possible to remove one letter
            }

            return "OK";
        }
    }
}
