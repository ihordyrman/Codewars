using System;

namespace Moving_Zeros_To_The_End
{
    class Program
    {
        // https://www.codewars.com/kata/52597aa56021e91c93000cb0
        
        // Write an algorithm that takes an array and moves all of the zeros to the end,
        // preserving the order of the other elements.
        // MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
        static void Main(string[] args)
        {
            var x = MoveZeroes(new int[] {0, 1, 2, 0, 1, 0, 1, 0, 3, 1});
        }

        private static int[] MoveZeroes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0) continue;

                for (int j = i; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[^1] = 0;
            }
            return arr;
        }

        private static int[] MoveZeroes2(int[] arr)
        {
            int count = 0;
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                    continue;
                }

                newArr[i - count] = arr[i];
            }

            return newArr;
        }
    }
}
