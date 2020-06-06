using System;
using System.Collections.Generic;

namespace Integer_depth
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeDepth(42));
        }

        private static int ComputeDepth(int n)
        {
            var arr = new List<char>(new[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'});
            var i = 1;
            for (; arr.Count > 0; i++)
            {
                foreach (var c in (i * n).ToString()) arr.Remove(c);
            }

            return i - 1;
        }
    }
}