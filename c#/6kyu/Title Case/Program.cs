using System;
using System.Linq;

namespace Title_Case
{
    /*
     * https://www.codewars.com/kata/5202ef17a402dd033c000009/train/csharp
     * Title Case
     *
     * A string is considered to be in title case if each word in the string is either (a) capitalised
     * (that is, only the first letter of the word is in upper case) or (b) considered to be an exception
     * and put entirely into lower case unless it is the first word, which is always capitalised.
     * Write a function that will convert a string into title case,
     * given an optional list of exceptions (minor words).
     * The list of minor words will be given as a string with each word separated by a space.
     * Your function should ignore the case of the minor words string --
     * it should behave in the same way even if the case of the minor word string is changed.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TitleCase("a clash of KINGS", "a an the of"));
            Console.WriteLine(TitleCase("a clash of KINGS", "a an the of"));
            Console.WriteLine(TitleCase("THE WIND IN THE WILLOWS", "The In"));
            Console.WriteLine(TitleCase("The Quick Brown Fox"));
        }

        private static string TitleCase(string title, string minorWords = "")
        {
            if (string.IsNullOrEmpty(title)) return title;

            var minors = !string.IsNullOrEmpty(minorWords) && minorWords.Length > 0
                ? minorWords.ToLower().Split(" ")
                : Array.Empty<string>();
            var words = title.ToLower().Split(" ");
            var result = string.Empty;

            foreach (var w in words)
            {
                if (minors.All(x => x != w))
                    result += char.ToUpper(w[0]) + w.Remove(0, 1) + " ";
                else
                {
                    var word = minors.FirstOrDefault(x => x == w);
                    if (result == string.Empty)
                    {
                        result += char.ToUpper(word[0]);
                        if (word.Length > 1) result += word.Remove(0, 1);
                    }
                    else result += word;

                    result += " ";
                }
            }

            return result.TrimEnd();
        }
    }
}