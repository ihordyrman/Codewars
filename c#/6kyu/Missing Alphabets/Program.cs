using System;
using System.Collections.Generic;
using System.Linq;

namespace Missing_Alphabets
{
    /*
    * Given string s, which contains only letters from a to z in lowercase.
    * A set of alphabet is given by abcdefghijklmnopqrstuvwxyz.
    * 2 sets of alphabets mean 2 or more alphabets.
    * Your task is to find the missing letter(s). 
    * You may need to output them by the order a-z. 
    * It is possible that there is more than one missing letter from more than one set of alphabet.
    * If the string contains all of the letters in the alphabet, return an empty string ""
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingAlphabets("abcdefghijklmnopqrstuvwxy"));
            Console.WriteLine(MissingAlphabets("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(MissingAlphabets("aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy"));
            Console.WriteLine(BetterMissingAlphabets("abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxy"));
            Console.WriteLine(BetterMissingAlphabets("codewars"));
        }

        private static string MissingAlphabets(string s)
        {
            var missing = string.Empty;
            var count = new Dictionary<char, int>();

            while (s.Length > 0)
            {
                for (var i = 97; i < 123; i++)
                {
                    if (!count.ContainsKey((char) i))
                        count.Add((char) i, 0);

                    if (s.Contains((char) i))
                        s = s.Remove(s.IndexOf((char) i), 1);
                    else
                        count[(char) i] = count[(char) i] + 1;
                }
            }

            return count.Where(x => x.Value > 0)
                .Aggregate(missing, (current, x) => current + new string(x.Key, x.Value));
        }

        private static string BetterMissingAlphabets(string s)
        {
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            var dic = alphabet.ToDictionary(x => x, l => s.Count(x => x == l));
            return string.Concat(alphabet.SelectMany(x => Enumerable.Repeat(x, dic.Max(z => z.Value) - dic[x])));
        }
    }
}