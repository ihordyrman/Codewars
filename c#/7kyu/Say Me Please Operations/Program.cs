using System;
using System.Linq;

namespace Say_Me_Please_Operations
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(SayMeOperations("1 2 3 5 8"));
            Console.WriteLine(SayMeOperations("9 4 5 20 25"));
            Console.WriteLine(SayMeOperations("10 2 5 -3 -15 12"));
            Console.WriteLine(SayMeOperations("2 2 4"));
        }

        private static string SayMeOperations(string stringNumbers)
        {
            var arr = stringNumbers.Split(" ").Select(int.Parse).ToArray();
            var result = new string[arr.Length - 2];

            for (var i = 1; i < arr.Length - 1; i++)
                result[i - 1] = arr[i - 1] + arr[i] == arr[i + 1] ? "addition" :
                    arr[i - 1] * arr[i] == arr[i + 1] ? "multiplication" :
                    arr[i - 1] - arr[i] == arr[i + 1] ? "subtraction" :
                    arr[i - 1] / arr[i] == arr[i + 1] ? "division" : throw new Exception("fuck off");

            return string.Join(", ", result);
        }
    }
}