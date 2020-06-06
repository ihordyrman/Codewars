using System;
using System.Collections.Generic;
using System.Linq;

namespace k_Primes
{
    class Program
    {
        // https://www.codewars.com/kata/5726f813c8dcebf5ed000a6b

        static void Main(string[] args)
        {
            WriteAnArray(CountKprimes(2, 0, 100));
            WriteAnArray(CountKprimes(3, 0, 100));
            WriteAnArray(CountKprimes(5, 1000, 1100));
            WriteAnArray(CountKprimes(5, 500, 600));
        }

        // A natural number is called k-prime if it has exactly k prime factors,
        // counted with multiplicity. For example:
        // k = 2  -->  4, 6, 9, 10, 14, 15, 21, 22, ...
        // k = 3  -->  8, 12, 18, 20, 27, 28, 30, ...
        // k = 5  -->  32, 48, 72, 80, 108, 112, ...

        // A natural number is thus prime if and only if it is 1-prime.
        // Task:
        // Complete the function count_Kprimes (or countKprimes, count-K-primes, kPrimes)
        // which is given parameters k, start, end (or nd) and returns an array
        // (or a list or a string depending on the language - see "Solution" and "Sample Tests")
        // of the k-primes between start (inclusive) and end (inclusive).

        // Example:
        // countKprimes(5, 500, 600) --> [500, 520, 552, 567, 588, 592, 594]
        private static long[] CountKprimes(int k, long start, long end)
        {
            var list = new List<long>();
            for (var i = start; i <= end; i++)
            {
                if (IsPrime(i)) continue;
                var count = 1;
                var temp = i;

                while (!IsPrime(temp))
                {
                    for (var j = 2; j < temp; j++)
                    {
                        if (!IsPrime(j) || temp % j != 0) continue;
                        temp /= j;
                        count++;
                        break;
                    }
                }

                if (count == k) list.Add(i);
            }

            return list.ToArray();
        }

        // Given a positive integer s, find the total number of solutions of
        // the equation a + b + c = s, where a is 1-prime, b is 3-prime, and c is 7-prime.
        public static int Puzzle(int s)
        {
            return 0;
        }

        private static bool IsPrime(long number)
        {
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static void WriteAnArray(long[] arr) =>
            Console.WriteLine(arr.Aggregate("", (current, l) => current + (l + " ")));
    }
}