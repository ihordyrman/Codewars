using System;
using System.Text.RegularExpressions;

namespace Word_a10n__abbreviation_
{
    static class Program
    {
        // https://www.codewars.com/kata/5375f921003bf62192000746/train/csharp
        
        // Write a function that takes a string and turns any and all "words" (see below)
        // within that string of length 4 or greater into an abbreviation, following these rules:

        // A "word" is a sequence of alphabetical characters.
        // By this definition, any other character like a space or hyphen (eg. "elephant-ride")
        // will split up a series of letters into two words (eg. "elephant" and "ride").
        // The abbreviated version of the word should have the first letter,
        // then the number of removed characters, then the last letter (eg. "elephant ride" => "e6t r2e").
        static void Main(string[] args)
        {
            Console.WriteLine(Abbreviate("my. dog, isn't feeling very well.")); // "my. dog, isn't f5g v2y w2l."
            Console.WriteLine(Abbreviate("elephant-rides are really fun!")); // "e6t-r3s are r4y fun!"
        }

        private static string Abbreviate(string input)
        {
            return Regex.Replace(input, @"[a-zA-Z]{4,}", x => x.Value[0] + (x.Length-2).ToString() + x.Value[x.Length-1]);
        }
    }
}
