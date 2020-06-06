using System;
using System.Linq;

namespace Parts_of_a_list
{
    class Program
    {
        // https://www.codewars.com/kata/56f3a1e899b386da78000732/train/csharp

        // Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.

        // Each two non empty parts will be in a pair (or an array for
        // languages without tuples or a structin C - C: see Examples test Cases - )
        // Each part will be in a string
        // Elements of a pair must be in the same order as in the original array.
        static void Main(string[] args)
        {
            var a = Partlist(new[] {"Here"});
            var b = Partlist(new[] {"vJQ", "anj", "mQDq", "sOZ"});
            var c = BetterPartlist(new[] {"I", "wish", "I", "hadn't", "come"});
            var d = BetterPartlist(new[] {"cdIw", "tzIy", "xDu", "rThG"});
        }

        private static string[][] Partlist(string[] arr)
        {
            var result = new string[arr.Length - 1][];

            for (var i = 0; i < arr.Length - 1; i++)
            {
                var temp = arr[i];
                arr[i] += ",";
                result[i] = new[] {$"{string.Join(' ', arr)}"};
                arr[i] = temp;
            }

            return result;
        }

        private static string[][] BetterPartlist(string[] arr)
        {
            return Enumerable.Range(1, arr.Length - 1).Select(x =>
                new[] {
                    string.Join(" ", arr.Take(x)),
                    string.Join(" ", arr.Skip(x).Take(arr.Length - x))
                }).ToArray();
        }
    }
}