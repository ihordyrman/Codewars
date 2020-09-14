using System.Collections.Generic;
using System.Linq;

namespace String_array_duplicates
{
    /*
        String array duplicates
        In this Kata, you will be given an array of strings and your task 
        is to remove all consecutive duplicate letters from each string in the array.
    */
    internal static class Program
    {
        private static void Main()
        {
            Dup(new[] {"abracadabra","allottee","assessee"}); // "abracadabra","alote","asese"
            DupRegex(new[] {"kelless","keenness"}); // "keles","kenes"
        }

        private static string[] Dup(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var word = string.Empty;
                word += arr[i][0];
                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (arr[i][j] != arr[i][j-1]) 
                        word += arr[i][j];
                }
                arr[i] = word;
            }

            return arr;
        }

        private static IEnumerable<string> DupRegex(IEnumerable<string> arr) => 
            arr.Select(x => x.Aggregate("", (c, n) => c.EndsWith(n) ? c : c + n));
    }
}
