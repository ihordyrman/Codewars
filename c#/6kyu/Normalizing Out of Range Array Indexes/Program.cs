using System;
using System.Collections.Generic;

namespace Normalizing_Out_of_Range_Array_Indexes
{
    internal static class Program
    {
        private static void Main()
        {
            var arr = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(NormIndex(arr, arr.Length)); // 0
            Console.WriteLine(NormIndex(arr, arr.Length + 1)); // 1
            Console.WriteLine(NormIndex(arr, arr.Length + 2)); // 2
            Console.WriteLine(NormIndex(arr, arr.Length * 2)); // 0
            Console.WriteLine(NormIndex(arr, -arr.Length)); // 0
        }

        private static int NormIndex(int[] array, int index)
        {
            while (index < 0) index += array.Length;
            return array[index % array.Length];
        }
    }
}