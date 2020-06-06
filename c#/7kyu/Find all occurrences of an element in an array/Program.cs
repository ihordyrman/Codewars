using System;
using System.Collections.Generic;
using System.Linq;


namespace Find_all_occurrences_of_an_element_in_an_array
{
    // https://www.codewars.com/kata/find-all-occurrences-of-an-element-in-an-array/train/csharp
    
    // Given an array (a list in Python) of integers and an integer n,
    // find all occurrences of n in the given array and return another
    // array containing all the index positions of n in the given array.

    // If n is not in the given array, return an empty array [].
    //
    // Assume that n and all values in the given array will always be integers.
    
    // Example:

    // Kata.FindAll(new int[] {6, 9, 3, 4, 3, 82, 11}, 3) => new int[] {2, 4}
    static class Program
    {
        static void Main(string[] args)
        {
            FindAll(new int[] {6, 9, 3, 4, 3, 82, 11}, 3);
        }

        private static int[] FindAll(int[] array, int n)
        {
            var indexes = new List<int>();
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == n) indexes.Add(i);
            }
            return indexes.ToArray();
        }

        private static int[] BetterFindAll(int[] arr, int n)
        {
            return arr.Select((v, i) => v == n ? i : -1).Where(i => i >= 0).ToArray();
        }
    }
}
