using System;
using System.Collections.Generic;
using System.Linq;

namespace Array.diff
{
    // https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
    // Your goal in this kata is to implement a difference function,
    // which subtracts one list from another and returns the result.

    // It should remove all values from list a, which are present in list b.

    // Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
    // If a value is present in b, all of its occurrences must be removed from the other:
    // Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}

    static class Program
    {
        private static void Main(string[] args)
        {
            var a = ArrayDiff(new[] {1, 2}, new[] {1});
            var b = ArrayDiff(new[] {1, 2, 2}, new[] {1});
            var c = ArrayDiff(new[] {1, 2, 2}, new[] {2});
            var d = ArrayDiff(new[] {1, 2, 2}, new int[] { });
            var e = ArrayDiff(new int[] { }, new[] {1, 2});
        }

        private static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(i => !b.Contains(i)).ToArray();
        }
    }
}
