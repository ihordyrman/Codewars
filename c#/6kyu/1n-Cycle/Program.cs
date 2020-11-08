using System;

namespace _1n_Cycle
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Running(7));
            Console.WriteLine(Running(5));
            Console.WriteLine(Running(13));
            Console.WriteLine(Running(94));
            Console.WriteLine(Running(37));
            Console.WriteLine(Running(33));
            Console.WriteLine(Running(27));
        }

        private static int Running(int n)
        {
            if (n % 2 == 0 || n % 5 == 0)
                return -1;

            var result = 1;

            for (var i = 1; i <= n; i++)
            {
                result = result * 10 % n;
                if (result == 1) 
                    return i;
            }

            return -1;
        }
    }
}