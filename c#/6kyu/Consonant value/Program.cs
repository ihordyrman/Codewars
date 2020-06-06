using System;
using System.Linq;

namespace Consonant_value
{
    class Program
    {
        // https://www.codewars.com/kata/59c633e7dcc4053512000073/train/csharp

        // Given a lowercase string that has alphabetic characters only and no spaces,
        // return the highest value of consonant substrings. Consonants are any letters of the alpahabet except "aeiou". 1 5 9 15 21

        // We shall assign the following values: a = 1, b = 2, c = 3, .... z = 26.
        // For example, for the word "zodiacs", let's cross out the vowels. We get: "z o d ia cs"
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("zodiacs"));
        }

        private static int Solve(string s)
        {
            var ints = s.Select(y => y - 'a' + 1).ToArray();
            var max = 0;
            var currentMax = 0;
            foreach (var t in ints)
            {
                if (t == 1 || t == 5 || t == 9 || t == 15 || t == 21)
                {
                    currentMax = 0;
                    continue;
                }
                currentMax += t;
                max = currentMax > max ? currentMax : max;
            }
            return max;
        }
        
        private static int MuchCleverSolve(string s)
        {
            return s.Split('a', 'e', 'i', 'o', 'u')
                .Select(x => x.Sum(y => y-96))
                .Max();
        }
    }
}