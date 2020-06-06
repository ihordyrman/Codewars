using System;
using System.Collections.Generic;
using System.Linq;

// Complete the solution so that it takes the object (JavaScript/CoffeeScript) or
// hash (ruby) passed in and generates a human readable string from its key/value pairs.

// The format should be "KEY = VALUE". Each key/value pair should be separated by a comma except for the last pair.
namespace BuildingStringsFromHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringifyDict(new Dictionary<char, int> {{'a', 1}, {'b', 2}}));
            Console.WriteLine(StringifyDict(new Dictionary<char, int> {{'b', 1}, {'c', 2}, {'e', 3}}));
            Console.WriteLine(StringifyDict(new Dictionary<char, int>()));
        }

        private static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            var result = string.Empty;
            foreach (var (key, value) in hash) result += $"{key} = {value},";
            return result == string.Empty ? "" : result.Remove(result.Length - 1);
        }

        private static string BetterStringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash) =>
            string.Join(",", hash.Select(x => $"{x.Key} = {x.Value}"));
    }
}
