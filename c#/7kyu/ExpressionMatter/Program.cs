using System;

namespace ExpressionMatter
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(ExpressionsMatter(1, 2, 3));
            Console.WriteLine(ExpressionsMatter(1,6,1));
        }

        private static int ExpressionsMatter(int a, int b, int c) =>
            Math.Max(Math.Max(Math.Max(a * (b + c), a * b * c), Math.Max(a + b * c, (a + b) * c)), a + b + c);
    }
}
