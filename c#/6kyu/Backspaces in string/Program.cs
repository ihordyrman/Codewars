using System;

namespace Backspaces_in_string
{
    /*
     * Backspaces in string
     * https://www.codewars.com/kata/5727bb0fe81185ae62000ae3/train/csharp
     *
     * Assume "#" is like a backspace in string. This means that string "a#bc#d" actually is "bd"
     * Your task is to process a string with "#" symbols.
     */
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(CleanString("abc#d##c"));
            Console.WriteLine(CleanString("abc##d######"));
            Console.WriteLine(CleanString("abc####d##c#"));
            Console.WriteLine(CleanString("#######"));
            Console.WriteLine(CleanString(""));
        }

        private static string CleanString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            var result = string.Empty;

            foreach (var ch in s)
            {
                if (ch != '#')
                {
                    result += ch;
                    continue;
                }

                if (result.Length <= 0) continue;
                result = result.Remove(result.Length - 1, 1);
            }

            return result;
        }
    }
}