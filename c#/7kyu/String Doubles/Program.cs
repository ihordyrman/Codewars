using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace String_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoublesRegex("abbbzz"));
            Console.WriteLine(DoublesRegex("zzzzykkkd"));
            Console.WriteLine(DoublesRegex("abbcccdddda"));
            Console.WriteLine(DoublesRegex("vvvvvoiiiiin"));
            Console.WriteLine(DoublesRegex("rrrmooomqqqqj"));
            Console.WriteLine(DoublesRegex("xxbnnnnnyaaaaam"));
        }

        private static string Doubles(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            var result = string.Empty;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i + 1] == str[i])
                {
                    i++;
                    continue;
                }

                result += str[i];
            }

            return (str[^1] != str[^2] || (str[^2] == str[^1] && str[^3] == str[^1])) ? result + str[^1] : result;
        }

        private static string DoublesRegex(string str) {
            return Regex.Replace(str, @"(\w)\1", "");
        }
    }
}
