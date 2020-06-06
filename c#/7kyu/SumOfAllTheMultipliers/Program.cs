using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfAllTheMultipliers
{
    internal static class Program
    {
        private static void Main() => Console.WriteLine(FindSum(100));

        private static int FindSum(int n)
        {
            var nums = new HashSet<int>();
            for (var i = 0; i <= n; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    nums.Add(i);

            return nums.Sum();
        }

        private static int AnotherFindSum(int n) =>
            Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
    }
}
