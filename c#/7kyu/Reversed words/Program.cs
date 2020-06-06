using System;
using System.Linq;

namespace Reversed_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("world! hello"));
        }

        private static string ReverseWords(string str)
        {
            var words = str.Split(" ");
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
