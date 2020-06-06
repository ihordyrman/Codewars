using System;
using System.Linq;

namespace ToSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = SquareOrSquareRoot(new[] {4, 3, 9, 7, 2, 1});
            Console.WriteLine(string.Join(" ", array));
        }

        private static int[] SquareOrSquareRoot(int[] array) =>
            array.Select(x => Math.Sqrt(x) % 1 == 0 ? (int) Math.Sqrt(x) : x * x).ToArray();
    }
}
