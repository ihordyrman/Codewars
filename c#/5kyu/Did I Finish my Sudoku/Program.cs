using System;
using System.Linq;

namespace Did_I_Finish_my_Sudoku
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(DoneOrNot(new[]
            {
                new[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
                new[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
                new[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
                new[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
            }));

            Console.WriteLine(DoneOrNot(new[]
            {
                new[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                new[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                new[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                new[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            }));
        }

        private static string DoneOrNot(int[][] board)
        {
            var columns = new int[board.Length];
            var rows = new int[board.Length];
            var regions = new int[board.Length];

            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 0) return "Try again!";
                    columns[i] = board[i][j];
                    rows[j] = board[i][j];

                    regions[j] += board[i / 3 * 3 + j / 3][j % 3 + i % 3 * 3];
                }

                if (rows.Distinct().Count() != rows.Length
                    || columns.Distinct().Count() != columns.Length
                    || regions.Distinct().Count() != regions.Length)
                    return "Try again!";
            }

            return "Finished!";
        }
    }
}