using System;
using System.Collections.Generic;
using System.Linq;

namespace Snail
{
    class Program
    {
        // https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1

        // Given an n x n array, return the array elements arranged
        // from outermost elements to the middle element, traveling clockwise.

        // array = [[1,2,3],
        //         [4,5,6],
        //         [7,8,9]]
        // snail(array) #=> [1,2,3,6,9,8,7,4,5]

        // For better understanding, please follow the numbers of the next array consecutively:
        // array = [[1,2,3],
        //         [8,9,4],
        //         [7,6,5]]
        // snail(array) #=> [1,2,3,4,5,6,7,8,9]

        // NOTE: The idea is not sort the elements from the lowest value to the highest;
        // the idea is to traverse the 2-d array in a clockwise snailshell pattern.
        // NOTE 2: The 0x0 (empty matrix) is represented as en empty array inside an array [[]].
        static void Main(string[] args)
        {
            // int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //
            // for (int j = arr.Length - 1; j >= 0; j--)
            // {
            //     Console.WriteLine(arr[j]);
            // }

            int[][] array =
            {
                new[] {1, 2, 3, 4},
                new[] {5, 6, 7, 8},
                new[] {9, 10, 11, 12},
                new[] {13, 14, 15, 16}
            };

            // for (var i = 0; i < array.Length; i++)
            // for (var j = 0; j < array[i].Length; j++)
            //     Console.WriteLine(array[i][j]);

            DisplayArray(Snail(array));
        }

        private static IEnumerable<int> Snail(int[][] array)
        {
            // TODO: Need to finish
            var list = new List<int>();
            int x_index = 0;
            int y_index = 0;
            int x_start = 0;
            int y_start = 0;
            bool reversed = false;
            while (true)
            {
                if (!reversed)
                {
                    x_start = x_index;
                    for (var i = x_index; i < array.Length; i++)
                    {
                        x_index = i;
                        for (var j = y_index; j < array[i].Length; j++)
                        {
                            y_index = j;
                            list.Add(array[i][j]);
                        }
                    }

                    y_start = y_index;
                    reversed = true;
                }
                else
                {
                    x_index--;
                    for (var i = y_index; i >= 0; i--)
                    {
                        for (var j = x_index; j >= 0; j--)
                        {
                            list.Add(array[i][j]);
                        }

                        y_index--;
                        break;
                    }
                    
                    for (var i = y_start-1; i > y_start; i--)
                    {
                        for (int j = x_index - 1; j > x_start; j--)
                        {
                            x_index--;
                            list.Add(array[i][j]);
                        }
                        Console.WriteLine("");
                    }

                    reversed = false;
                }
            }

            return new int[] { };
        }

        private static void DisplayArray(IEnumerable<int> arr) =>
            Console.WriteLine(arr.Aggregate("", (current, i) => current + i + " ").Trim());
    }
}