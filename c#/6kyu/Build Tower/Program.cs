using System;

namespace Build_Tower
{
    internal static class Program
    {
        /*
         * https://www.codewars.com/kata/576757b1df89ecf5bd00073b/
         * Build Tower by the following given argument: number of floors (integer and always greater than 0).
         */
        static void Main()
        {
            var tower = TowerBuilder(3);
            foreach (var t in tower) Console.WriteLine(t);
        }

        private static string[] TowerBuilder(int nFloors)
        {
            if (nFloors == 0) return new string[] {};
            var tower = new string[nFloors];
            var spacesCount = nFloors - 1;
            for (var i = 0; i < tower.Length; i++)
            {
                var stars = i == 0 ? 1 : i * 2 + 1;
                var spaces = new string(' ', spacesCount);
                tower[i] = spaces + new string('*', stars) + spaces;
                spacesCount--;
            }

            return tower;
        }
    }
}