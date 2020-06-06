using System;
using System.Linq;

namespace Highest_Rank_Number_in_an_Array
{
    static class Program
    {
        // https://www.codewars.com/kata/5420fc9bb5b2c7fd57000004/train/csharp

        // Complete the method which returns the number which is most frequent in the given input array.
        // If there is a tie for most frequent number, return the largest number among them.

        // Note: no empty arrays will be given.
        static void Main(string[] args)
        {
            Console.WriteLine(HighestRank(new[] {12, 10, 8, 12, 7, 6, 4, 10, 12 }));
            Console.WriteLine(HighestRank(new[] {12, 10, 8, 12, 7, 6, 4, 10, 12, 10}));
            Console.WriteLine(CleverHighestRank(new[] {12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10}));
        }

        private static int HighestRank(int[] arr)
        {
            var result = arr.GroupBy(x => x).ToArray();
            var maxCount = result[0].Count(); 
            var maxValue = result[0].Key;
            for (var i = 1; i < result.Length; i++)
            {
                if (maxCount >= result[i].Count() && 
                    (maxCount != result[i].Count() 
                     || maxValue >= result[i].Key)) continue;
                
                maxCount = result[i].Count();
                maxValue = result[i].Key;
            }
            return maxValue;
        }

        private static int CleverHighestRank(int[] arr)
        {
            return arr
                .GroupBy(i => i)
                .OrderByDescending(gr => gr.Count())
                .ThenByDescending(gr => gr.Key)
                .Select(gr => gr.Key)
                .First();
        }
    }
}