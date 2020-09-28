using System;
using System.Collections.Generic;

namespace Iterative_Rotation_Cipher
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Encode(10, "If you wish to make an apple pie from scratch, you must first invent the universe."));
        }

        public static string Encode(int n, string s)
        {
            var spaces = new List<int>();

            for (int i = 0; i < s.Length; i++)
                if (s[i] == ' ') spaces.Add(i);

            s = s.Replace(" ", "");
            s = s[^n..] + s.Substring(0, s.Length - n);

            for (int i = 0; i < spaces.Count; i++)
                s = s.Insert(spaces[i], " ");

            var arr = s.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < n; j++)
                    arr[i] = arr[i][^1] + arr[i][..^1];
            }

            return string.Join(" ", arr);
        }
        public static string Decode(string s)
        {
            // todo: finish
            return null;
        }
    }
}
