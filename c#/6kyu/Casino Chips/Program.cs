using System;
using System.Linq;

namespace Casino_Chips
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Solve(new[] {1, 1, 1}));
            Console.WriteLine(Solve(new[] {1, 2, 1}));
            Console.WriteLine(Solve(new[] {4, 1, 1}));
            Console.WriteLine(Solve(new[] {8, 2, 8}));
            Console.WriteLine(Solve(new[] {8, 1, 4}));
            Console.WriteLine(BetterSolve(new[] {7, 4, 10}));
            Console.WriteLine(BetterSolve(new[] {12, 12, 12}));
            Console.WriteLine(BetterSolve(new[] {1, 23, 2}));
        }

        private static int Solve(int[] arr)
        {
            var count = 0;
            Array.Sort(arr);
            while (arr[1] > 0)
            {
                arr[2]--;
                arr[1]--;
                count++;
                Array.Sort(arr);
            }

            return count;
        }

        private static int BetterSolve(int[] arr)
        {
            Array.Sort(arr, 0, 3);
            return Math.Min((arr[0] + arr[1] + arr[2]) / 2 | 0, arr[0] + arr[1]);
        }
    }
}