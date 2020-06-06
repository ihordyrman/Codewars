using System;
using System.Linq;

namespace Replace_With_Alphabet_Position
{
    class Program
    {
        // https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp

        // In this kata you are required to, given a string, replace every letter with its position in the alphabet.
        // If anything in the text isn't a letter, ignore it and don't return it.
        // "a" = 1, "b" = 2, etc.
        // Example
        // Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
        // Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
            Console.WriteLine(AlphabetPosition("The narwhal bacons at midnight."));
        }

        private static string AlphabetPosition(string text)
        {
            return text.Where(x => char.ToUpper(x) - 64 > 0 && char.ToUpper(x) - 64 < 27)
                .ToArray()
                .Aggregate(string.Empty, (current, word) 
                    => current + ((char.ToUpper(word) - 64) + " ")).Trim();
        }
    }
}