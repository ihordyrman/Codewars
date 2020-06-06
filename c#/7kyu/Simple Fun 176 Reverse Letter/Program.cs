using System;

namespace Simple_Fun_176_Reverse_Letter
{
    class Program
    {
        // https://www.codewars.com/kata/simple-fun-number-176-reverse-letter/train/csharp

        //Given a string str, reverse it omitting all non-alphabetic characters.

        // Example
        // For str = "krishan", the output should be "nahsirk".
        //
        // For str = "ultr53o?n", the output should be "nortlu".
        //
        // Input/Output
        // [input] string str
        //
        // A string consists of lowercase latin letters, digits and symbols.
        //
        // [output] a string
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseLetter("nahs1irk"));
        }

        public static string ReverseLetter(string str)
        {
            //coding and coding..
            var reversed = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                if (Char.IsLetter(str[i])) reversed += str[i];
            }
            return reversed;
        }
    }
}