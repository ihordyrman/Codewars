using System;
using System.Linq;

namespace Form_The_Minimum
{
    class Program
    {
        // https://www.codewars.com/kata/form-the-minimum/train/csharp
        
        // Given a list of digits, return the smallest number that could be
        // formed from these digits, using the digits only once (ignore duplicates).
        // Only positive integers will be passed to the function (> 0 ), no negatives or zeros.
        
        static void Main(string[] args)
        {
            Console.WriteLine(MinValue(new[] {1, 1, 2, 3, 3, 4, 5, 6}));
        }

        private static long MinValue(int[] a)
        {
            return long.Parse(string.Join("", a.OrderBy(x => x).Distinct().ToArray()));
        }
    }
}