using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_the_odd
{
    static class Program
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(' ', SortArray(new[] {5, 3, 2, 8, 1, 4})));
            Console.WriteLine(string.Join(' ', SortArray(new[] {5, 3, 1, 8, 0})));
            Console.WriteLine(string.Join(' ', SortArray(new int[] { })));
        }

        private static int[] SortArray(int[] array)
        {
            var list = new Queue<int>(array.Where(x => x % 2 != 0).OrderBy(y => y));
            for (var i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0)
                    array[i] = list.Dequeue();

            return array;
        }
    }
}