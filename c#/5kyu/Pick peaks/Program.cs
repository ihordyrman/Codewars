using System;
using System.Collections.Generic;
using System.Linq;

namespace Pick_peaks
{
    class Program
    {
        // https://www.codewars.com/kata/5279f6fe5ab7f447890006a7

        // In this kata, you will write a function that returns the positions 
        // and the values of the "peaks" (or local maxima) of a numeric array.

        // For example, the array arr = [0, 1, 2, 5, 1, 0] has a peak at 
        // position 3 with a value of 5 (since arr[3] equals 5).

        // The output will be returned as a Dictionary<string, List<int>> with two 
        // key-value pairs: "pos" and "peaks". If there is no peak in the given array, 
        // simply return {"pos" => new List<int>(), "peaks" => new List<int>()}.

        // Example: pickPeaks([3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3]) should return 
        // {pos: [3, 7], peaks: [6, 3]} (or equivalent in other languages)

        // All input arrays will be valid integer arrays (although it could still be empty), 
        // so you won't need to validate the input.

        // The first and last elements of the array will not be considered as peaks 
        // (in the context of a mathematical function, we don't know what is after 
        // and before and therefore, we don't know if it is a peak or not).

        // Also, beware of plateaus !!! [1, 2, 2, 2, 1] has a peak while [1, 2, 2, 2, 3] does not. 
        // In case of a plateau-peak, please only return the position and value of the beginning of the plateau. 
        // For example: pickPeaks([1, 2, 2, 2, 1]) returns {pos: [1], peaks: [2]} (or equivalent in other languages)

        // Have fun! 
        static void Main()
        {
            var random = GetPeaks(new[]
                {-4, 14, 14, 2, 2, 16, 3, 0, 15, 12, 10, 18, 5, -3, -5, 12, 1, 4, -5, 13, 5, 10, 19});

            // 3,7  // 6,3
            var a = GetPeaks(new[] {1, 2, 3, 6, 4, 1, 2, 3, 2, 1});

            // 3,7  // 6,3
            var b = GetPeaks(new[] {3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3});

            // 3,7,10  // 6,3,2
            var c = GetPeaks(new[] {3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 2, 2, 1});

            // 2,4  // 3,2
            var d = GetPeaks(new[] {2, 1, 3, 1, 2, 2, 2, 2, 1});

            // 2  // 3
            var e = GetPeaks(new[] {2, 1, 3, 1, 2, 2, 2, 2});
        }

        private static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var positions = new List<int>();
            var peaks = new List<int>();
            var result = new Dictionary<string, List<int>>();
            for (var i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i - 1] || arr[i] < arr[i + 1]) continue;
                var notPeek = false;
                var toTheEnd = true;

                if (arr[i] == arr[i + 1])
                {
                    for (var y = i; y < arr.Length; y++)
                    {
                        if (arr[i] > arr[y]) break;
                        if (arr[i] < arr[y]) notPeek = true;
                    }
                }

                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i]) continue;
                    toTheEnd = false;
                    break;
                }

                if (toTheEnd) break;
                if (notPeek) continue;
                positions.Add(i);
                peaks.Add(arr[i]);
            }

            result.Add("pos", positions);
            result.Add("peaks", peaks);
            return result;
        }
    }
}