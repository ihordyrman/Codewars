using System;

namespace Maze_Runner
{
    /*
     * 0 = Safe place to walk
     * 1 = Wall
     * 2 = Start Point
     * 3 = Finish Point
     *     N
     *    W E
     *     S
     */
    internal static class Program
    {
        private static void Main()
        {
            int[,] maze =
            {
                {1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 3},
                {1, 0, 1, 0, 1, 0, 1},
                {0, 0, 1, 0, 0, 0, 1},
                {1, 0, 1, 0, 1, 0, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 2, 1, 0, 1, 0, 1}
            };

            Console.WriteLine(MazeRunner(maze, new[] {"N", "N", "N", "N", "N", "E", "E", "E", "E", "E"}));
            Console.WriteLine(MazeRunner(maze, new[] {"N", "N", "N", "N", "N", "E", "E", "S", "S", "E", "E", "N", "N", "E"}));
            Console.WriteLine(MazeRunner(maze, new[] {"N", "N", "N", "N", "N", "E", "E", "E", "E", "E", "W", "W"}));
            Console.WriteLine(MazeRunner(maze, new[] {"N", "N", "N", "W", "W"}));
            Console.WriteLine(MazeRunner(maze, new[] {"N", "N", "N", "N", "N", "E", "E", "S", "S", "S", "S", "S", "S"}));
            Console.WriteLine(MazeRunner(maze, new[] {"N", "E", "E", "E", "E"}));
        }

        private static string MazeRunner(int[,] maze, string[] directions)
        {
            var (col, row) = (0, 0);
            for (var x = 0; x < maze.GetLength(0); x++)
            for (var y = 0; y < maze.GetLength(1); y++)
                if (maze[y, x] == 2)
                {
                    col = x;
                    row = y;
                }

            foreach (var move in directions)
            {
                switch (move)
                {
                    case "N": row -= 1; break;
                    case "E": col += 1; break;
                    case "S": row += 1; break;
                    case "W": col -= 1; break;
                }

                if (col > maze.GetLength(0) - 1
                    || col < 0
                    || row > maze.GetLength(1) - 1
                    || row < 0 || maze[row, col] == 1)
                    return "Dead";
                if (maze[row, col] == 3) return "Finish";
            }

            return "Lost";
        }
    }
}