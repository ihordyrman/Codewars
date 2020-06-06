using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Past(0, 1, 1)); // 61000
        }

        private static int Past(int h, int m, int s) =>
            (h > 0 ? h * 3600000 : 0) +
            (m > 0 ? m * 60000 : 0) +
            (s > 0 ? s * 1000 : 0);
    }
}
