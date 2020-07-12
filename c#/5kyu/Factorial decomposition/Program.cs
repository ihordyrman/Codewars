using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Factorial_decomposition
{
    /*
     * https://www.codewars.com/kata/5a045fee46d843effa000070/train/csharp
     * Factorial decomposition
     *
     * The aim of the kata is to decompose n! (factorial n) into its prime factors.
     * Prime numbers should be in increasing order. When the exponent of a prime is 1 don't put the exponent.
     *
     * the function is decomp(n) and should return the decomposition of n! into its prime factors in increasing order of the primes, as a string.
     * factorial can be a very big number (4000! has 12674 digits, n will go from 300 to 4000).
     * In Fortran - as in any other language - the returned string is not permitted to contain any redundant trailing whitespace:
     *     you can use dynamically allocated character strings.
     */
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decomp(12)); // "2^10 * 3^5 * 5^2 * 7 * 11"
            Console.WriteLine(DecompVol2(25)); // "2^22 * 3^10 * 5^6 * 7^3 * 11^2 * 13 * 17 * 19 * 23"
            Console.WriteLine(DecompVol2(22)); // "2^19 * 3^9 * 5^4 * 7^3 * 11^2 * 13 * 17 * 19"
        }

        // Works correct, but throws timeout exception :(
        private static string Decomp(int n)
        {
            // get primes
            var primes = Enumerable.Range(0, (int) Math.Floor(2.52 * Math.Sqrt(n) / Math.Log(n))).Aggregate(
                Enumerable.Range(2, n - 1).ToList(),
                (x, index) =>
                {
                    var bp = x[index];
                    var sqr = bp * bp;
                    x.RemoveAll(i => i >= sqr && i % bp == 0);
                    return x;
                }
            ).ToArray();

            // get factorial value
            BigInteger factorial = 1;
            long number = n;
            while (number != 1)
            {
                factorial *= number;
                number--;
            }

            // get dictionary with prime numbers
            var primesCount = primes.ToDictionary(i => i, i => 0);

            while (factorial > 1)
            {
                foreach (var t in primes)
                {
                    if (factorial % t != 0) continue;

                    factorial /= t;
                    primesCount[t]++;
                }
            }

            var result = string.Empty;
            foreach (var (key, value) in primesCount)
            {
                switch (value)
                {
                    case 1:
                        result += key + " * ";
                        break;
                    case { } x when x > 1:
                        result += key + "^" + value + " * ";
                        break;
                }
            }

            return result.Remove(result.Length - 3);
        }

        private static string DecompVol2(int n)
        {
            var primes = new List<int> { 2, 3 };

            var primesCount = new Dictionary<int, int>();

            while (n > 1)
            {
                var number = n;
                foreach (var prime in primes)
                {
                    while (number % prime == 0)
                    {
                        if (primesCount.ContainsKey(prime))
                            primesCount[prime]++;
                        else
                            primesCount[prime] = 1;
                        number /= prime;
                    }
                }

                while (number != 1)
                {
                    var next = primes.Last() + 2;

                    while (primes.Any(prime => next % prime == 0))
                    {
                        next += 2;
                    }

                    primes.Add(next);

                    while (number % next == 0)
                    {
                        if (primesCount.ContainsKey(next))
                            primesCount[next]++;
                        else
                            primesCount[next] = 1;

                        number /= next;
                    }
                }

                n--;
            }

            var result = string.Empty;
            foreach (var (key, value) in primesCount)
            {
                switch (value)
                {
                    case 1:
                        result += key + " * ";
                        break;
                    case { } x when x > 1:
                        result += key + "^" + value + " * ";
                        break;
                }
            }

            return result.Remove(result.Length - 3);
        }
    }
}