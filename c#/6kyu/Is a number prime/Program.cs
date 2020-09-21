using System;

namespace Is_a_number_prime
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(IsPrime(9));
            Console.WriteLine(IsPrime(1));
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(617));
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0) return false;

            return true;
        }
    }
}
