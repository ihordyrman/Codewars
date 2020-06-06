using System;
using System.Linq;

namespace RemoveDuplicatesFromList
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Distinct(new int[] {1, 1, 2}));
            Console.WriteLine(Distinct(new int[] {1, 2}));
        }

        private static int[] Distinct(int[] a) => a.Distinct().ToArray();
    }
}
