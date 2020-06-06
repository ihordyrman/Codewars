using System;

namespace Is_Divided
{
    class Program
    {
        static void Main(string[] args)
        {
            isDivisible(100, 10, 5);
        }

        private static bool isDivisible(long n, long x, long y)
        {
            return n % x == 0 && n % y == 0;
        }
    }
}
