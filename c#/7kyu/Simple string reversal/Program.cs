using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_string_reversal
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Solve("your code rocks"));
            Console.WriteLine(BetterSolve("your code rocks"));
        }

        private static string Solve(string s)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < s.Length; i++)
                if (s[i] == ' ') list.Add(i);

            var result = s.Replace(" ", "").Reverse().ToList();

            for (int i = 0; i < list.Count; i++)
                result.Insert(list[i], ' ');

            return string.Join("", result);
        }

        private static string BetterSolve(string s)
        {
            var result = s.ToCharArray();
            for (int i = 0, j = s.Length - 1; j >= 0; i++, j--)
            {
                if (s[i] == ' ') i++;
                if (s[j] == ' ') j--;
                result[i] = s[j];
            }
            return new string(result);
        }
    }
}
