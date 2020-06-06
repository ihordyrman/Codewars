using System;
using System.Collections.Generic;
using System.Linq;

namespace Sums_of_Parts
{
    class Program
    {
        // https://www.codewars.com/kata/5ce399e0047a45001c853c2b
        // Let us consider this example (array written in general format):
        // ls = [0, 1, 3, 6, 10]

        // Its following parts:
        // ls = [0, 1, 3, 6, 10]
        // ls = [1, 3, 6, 10]
        // ls = [3, 6, 10]
        // ls = [6, 10]
        // ls = [10]
        // ls = []

        // The corresponding sums are (put together in a list): [20, 20, 19, 16, 10, 0]

        // The function parts_sums (or its variants in other languages) will take as parameter
        // a list ls and return a list of the sums of its parts as defined above.
        static void Main(string[] args)
        {
            Console.WriteLine(WriteArray(PartsSums(new int[] {}))); // 0
            Console.WriteLine(WriteArray(PartsSums(new[] {0, 1, 3, 6, 10}))); // {20, 20, 19, 16, 10, 0};
            Console.WriteLine(WriteArray(PartsSums(new[] {1, 2, 3, 4, 5, 6}))); // {21, 20, 18, 15, 11, 6, 0};  
            Console.WriteLine(WriteArray(PartsSums(new[] {744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358}))); 
            // {10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0};
        }

        private static int[] PartsSums(int[] ls)
        {
            var arr = new int[ls.Length + 1];
            var sum = ls.Sum();
            for (var i = 0; i < ls.Length; i++)
            {
                arr[i] = sum;
                sum -= ls[i];
            }
            return arr;
        }

        private static string WriteArray(IEnumerable<int> arr) 
            => arr.Aggregate(string.Empty, (current, i) => current + (i + " ")).Trim();
    }
}