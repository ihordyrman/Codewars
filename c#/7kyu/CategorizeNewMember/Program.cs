using System;
using System.Collections.Generic;

namespace CategorizeNewMember
{
    static class Program
    {
        static void Main(string[] args)
        {
            var result = OpenOrSenior(
                new[]
                {
                    new[] {18, 20},
                    new[] {45, 2},
                    new[] {61, 12},
                    new[] {37, 6},
                    new[] {21, 21},
                    new[] {78, 9}
                });

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        private static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            foreach (var x in data)
                yield return x[0] > 54 && x[1] > 7 ? "Senior" : "Open";
        }
    }
}
