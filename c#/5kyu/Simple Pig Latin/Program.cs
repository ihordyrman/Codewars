using System;
using System.Linq;

namespace Simple_Pig_Latin
{
    class Program
    {
        // https://www.codewars.com/kata/520b9d2ad5c005041100000f

        // Move the first letter of each word to the end of it,
        // then add "ay" to the end of the word. Leave punctuation marks untouched.

        // Examples
        // Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
        // Kata.PigIt("Hello world !");     // elloHay orldway !
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Pig latin is cool"));
            Console.WriteLine(BetterPigIt("This is my string"));
        }

        private static string PigIt(string str)
        {
            var arr = str.Split(' ');
            var result = "";

            for (var i = 0; i < arr.Length; i++)
            {
                var end = arr[i][0] + "ay";
                arr[i] = arr[i].Remove(0, 1);
                result += arr[i] += end + " ";
            }

            return result.Trim();
        }

        private static string BetterPigIt(string str)
        {
            return string.Join(" ", str.Split(' ')
                .Select(w => w.Substring(1) + w[0] + "ay"));
        }
    }
}