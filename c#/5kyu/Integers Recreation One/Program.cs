using System;
using System.Collections.Generic;
using System.Linq;

namespace Integers_Recreation_One
{
    class Program
    {
        // https://www.codewars.com/kata/55aa075506463dac6600010d/train/csharp
        
        // Divisors of 42 are : 1, 2, 3, 6, 7, 14, 21, 42.
        // These divisors squared are: 1, 4, 9, 36, 49, 196, 441, 1764.
        // The sum of the squared divisors is 2500 which is 50 * 50, a square!

        // Given two integers m, n (1 <= m <= n) we want to find all integers between
        // m and n whose sum of squared divisors is itself a square. 42 is such a number.

        // The result will be an array of arrays or of tuples (in C an array of Pair) or a string,
        // each subarray having two elements, first the number whose squared
        // divisors is a square and then the sum of the squared divisors.
        // list_squared(1, 250) --> [[1, 1], [42, 2500], [246, 84100]]
        // list_squared(42, 250) --> [[42, 2500], [246, 84100]]
        
        // In Fortran - as in any other language - the returned string is not permitted
        // to contain any redundant trailing whitespace: you can use dynamically allocated character strings.
        static void Main(string[] args)
        {
            Console.WriteLine(ListSquared(1, 42));
        }

        private static string ListSquared(long m, long n)
        {
            Dictionary<long, long> results = new Dictionary<long, long>();
            for (long i = m; i <= n; i++)
            {
                long sumSqr = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) sumSqr += j * j;
                }
                
                if (Math.Sqrt(sumSqr) % 1 == 0) results.Add(i, sumSqr);
            }
            return $"[{string.Join(", ", results.Select(x => $"[{x.Key}, {x.Value}]"))}]";
        }
    }
}
