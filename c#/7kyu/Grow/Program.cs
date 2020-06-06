using System;
using System.Linq;

namespace Grow
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Grow(int[] x)
        {
            if (x == null || x.Length == 0) return 0;
            var multiply = x[0];
            for (var i = 1; i < x.Length; i++) multiply *= x[i];
            return multiply;
        }

        private static int BetterGrow(int[] x) => x.Aggregate((a, b) => a * b);
    }
}
