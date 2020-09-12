using System;

namespace Solomons_Quest_for_the_Temporal_Crystal
{
    class Program
    {
        static void Main(string[] args)
        {
            var map_example = new int[][]
            {
                new[] { 1, 3, 5 },
                new[] { 2, 0, 10 },
                new[] { -3, 1, 4 },
                new[] { 4, 2, 4 },
                new[] { 1, 1, 5 },
                new[] { -3, 0, 12 },
                new[] { 2, 1, 12 },
                new[] { -2, 2, 6 }
            };

            var x = SolomonsQuest(map_example);
        }

        public static int[] SolomonsQuest(int[][] ar)
        {
            var result = new int[] { 0, 0 };
            var timeDilation = 0;

            foreach (var dimension in ar)
            {
                timeDilation += dimension[0];
                for (var i = 0; i < 2; i++)
                    result[i] += (int)Math.Pow(2, timeDilation) * ((2 - i - dimension[1]) % 2) * dimension[2];
            }

            return result;
        }
    }
}
