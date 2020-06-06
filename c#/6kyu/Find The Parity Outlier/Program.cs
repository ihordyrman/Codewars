using System;
using System.Linq;

namespace Find_The_Parity_Outlier
{
    class Program
    {
        // https://www.codewars.com/kata/5526fc09a1bbd946250002dc

        // You are given an array (which will have a length of at least 3, but could be very large)
        // containing integers. The array is either entirely comprised of odd integers or entirely
        // comprised of even integers except for a single integer N. Write a method that takes the
        // array as an argument and returns this "outlier" N.
        static void Main(string[] args)
        {
            Console.WriteLine(Find(new[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 }));
        }

        private static int Find(int[] integers) =>
            integers.Count(z => z % 2 == 0) == 1
                ? integers.First(z => z % 2 == 0)
                : integers.First(z => z % 2 != 0);
    }
}
