using System;
using System.Collections.Generic;

namespace Iterative_Rotation_Cipher
{
    internal static class Program
    {
        private static void Main()
        {
            var encoded = Encode(10, "If you wish to make an apple pie from scratch, you must first invent the universe.");
            Console.WriteLine(encoded);
            var decoded = Decode(encoded);
            Console.WriteLine(decoded);
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

            return n + " " + string.Join(" ", arr);
        }
        public static string Decode(string s)
        {
            var arr = s.Split(" ");
            var n = int.Parse(arr[0]);
            var newArr = new string[arr.Length - 1];
            Array.Copy(arr, 1, newArr, 0, newArr.Length);

            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = 0; j < n; j++)
                    newArr[i] = newArr[i][^1] + newArr[i][..^1];
            }

            s = string.Join(" ", newArr);

            var spaces = new List<int>();

            for (int i = 0; i < s.Length; i++)
                if (s[i] == ' ') spaces.Add(i);

            s = s.Replace(" ", "");
            s =  s.Substring(n) + s.Substring(0, n);

            for (int i = 0; i < spaces.Count; i++)
                s = s.Insert(spaces[i], " ");

            return s;
        }
    }
}
