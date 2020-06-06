using System;
using System.Linq;

namespace Equal_Sides_Of_An_Array
{
    class Program
    {
        // https://www.codewars.com/kata/equal-sides-of-an-array/train/csharp

        // You are going to be given an array of integers.
        // Your job is to take that array and find an index N where the sum of the integers
        // to the left of N is equal to the sum of the integers to the right of N.
        // If there is no index that would make this happen, return -1.

        static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new[] {1, 2, 3, 4, 3, 2, 1})); // 3
            Console.WriteLine(FindEvenIndex(new[]
                {6471, 8665, 1294, -3724, 4450, -4251, 2724, 82, -6917, 1999, -3783, 4857, 8937, 3701})); // 8
            Console.WriteLine(FindEvenIndex(new[] {1, 100, 50, -51, 1, 1})); // 1
            Console.WriteLine(FindEvenIndex(new[] {1, 2, 3, 4, 5, 6})); // -1
            Console.WriteLine(FindEvenIndex(new[] {20, 10, 30, 10, 10, 15, 35})); // 3
        }

        private static int FindEvenIndex(int[] arr)
        {
            var leftSum = 0;
            var currentValue = 0;
            var rightSum = arr.Sum();

            for (var i = 0; i < arr.Length; i++)
            {
                leftSum += currentValue;
                currentValue = arr[i];
                rightSum -= currentValue;
                if (leftSum == rightSum)
                    return i;
            }

            return -1;
        }
    }
}