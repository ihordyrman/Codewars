using System;
using System.Linq;

namespace Sum_without_highest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] {6, 2, 1, 8, 10}));
        }

        private static int Sum(int[] numbers)
        {
            if (numbers.Length <= 1) return 0;
            return numbers.Sum() - numbers.Min() - numbers.Max();
        }
    }
}
