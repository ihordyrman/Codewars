using System;

namespace Triangle_number_check
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(BestIsTriangleNumber(10));
            Console.WriteLine(IsTriangleNumber(8));
        }

        private static bool IsTriangleNumber(long number)
        {
            long sum = 0;
            for (long i = 1; sum <= number; i++)
            {
                sum += i;
                if (sum == number)
                    return true;
            }
            return false;
        }

        private static bool BestIsTriangleNumber(long number) => Math.Sqrt(1 + 8 * number) % 1 == 0;
    }
}