using System;
using System.Linq;

namespace Stop_gninnipS
{
    // https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp

    // Write a function that takes in a string of one or more words,
    // and returns the same string, but with all five or more letter words reversed
    // (Just like the name of this Kata). Strings passed in will consist of only letters and spaces.
    // Spaces will be included only when more than one word is present.

    // Examples: spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
    // spinWords( "This is a test") => returns "This is a test" spinWords( "This is another test" )
    // => returns "This is rehtona test"
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(SpinWords("Hey fellow warriors"));
            Console.WriteLine(SpinWords("This is a test"));
            Console.WriteLine(SpinWords("This is another test"));
            Console.WriteLine(SpinWords("You are almost to the last test"));
            Console.WriteLine(BetterSpinWords("Just kidding there is still one more"));
        }

        private static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            for (var i = 0; i < words.Length; i++)
                if (words[i].Length > 4)
                    words[i] = string.Join("",
                        words[i].Reverse().ToArray());

            return string.Join(" ", words);
        }

        private static string BetterSpinWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ')
                .Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }
    }
}