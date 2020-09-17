using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominant_primes
{
    // The prime number sequence starts with: 2,3,5,7,11,13,17,19.... Notice that 2 is in position one.
    // 3 occupies position two, which is a prime-numbered position. Similarly, 5, 11 and 17 also occupy prime-numbered positions.
    // We shall call primes such as 3,5,11,17 dominant primes because they occupy prime-numbered positions in the prime number sequence
    // Let's call this listA.
    // As you can see from listA, for the prime range range(0,10), there are only two dominant primes (3 and 5) and the sum of these primes is: 3 + 5 = 8.
    // Similarly, as shown in listA, in the range (6,20), the dominant primes in this range are 11 and 17, with a sum of 28.
    // Given a range (a,b), what is the sum of dominant primes within that range?
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(solve(0, 10)); // 8
            Console.WriteLine(solve(2, 200)); // 1080
            Console.WriteLine(solve(1000, 100000)); // 52114889
            Console.WriteLine(solve(4000, 500000)); // 972664400
        }

        public static int solve(int a, int b)
        {
            List<int> list = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if (IsPrime(i))
                    list.Add(i);
            }

            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            List<int> list2 = new List<int>();
            for (int k = 0; k < list.Count; k++)
            {
                if (IsPrime(k + 1) && (k + 1) >=)
                {
                    list2.Add(list[k]);
                }
            }

            return list2.Sum();
        }
    }
}
