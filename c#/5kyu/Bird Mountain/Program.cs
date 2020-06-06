using System;
using System.Linq;

namespace Bird_Mountain
{
    internal class Program
    {
        // https://www.codewars.com/kata/5c09ccc9b48e912946000157/train/csharp

        // Kata Task
        // A bird flying high above a mountain range is able to estimate the height of the highest peak.
        // Can you?
        // Example
        // The birds-eye view
        // ^^^^^^
        //  ^^^^^^^^
        //   ^^^^^^^
        //   ^^^^^
        //   ^^^^^^^^^^^
        //   ^^^^^^
        //   ^^^^

        // The bird-brain calculations
        // 111111
        //  1^^^^111
        //   1^^^^11
        //   1^^^1
        //   1^^^^111111
        //   1^^^11
        //   1111

        // 111111
        //  12222111
        //   12^^211
        //   12^21
        //   12^^2111111
        //   122211
        //   1111

        // 111111
        //  12222111
        //   1233211
        //   12321
        //   12332111111
        //   122211
        //   1111

        // Height = 3
        private static void Main(string[] args)
        {
            char[][] first =
            {
                "^^^^^^        ".ToCharArray(),
                " ^^^^^^^^     ".ToCharArray(),
                "  ^^^^^^^     ".ToCharArray(),
                "  ^^^^^       ".ToCharArray(),
                "  ^^^^^^^^^^^ ".ToCharArray(),
                "  ^^^^^^      ".ToCharArray(),
                "  ^^^^        ".ToCharArray()
            };

            char[][] second =
            {
                "                    ^^^^^^                                          ".ToCharArray(),
                "                  ^^^^^^^^                                          ".ToCharArray(),
                "                 ^^^^^^^                                            ".ToCharArray(),
                "                  ^^^^^^^^                                          ".ToCharArray(),
                "                   ^^^^^^^                                          ".ToCharArray(),
                "                    ^^^^^^                                          ".ToCharArray(),
                "                    ^^^^                                            ".ToCharArray(),
                "                    ^^^^                                            ".ToCharArray(),
                "                     ^^                                             ".ToCharArray(),
                "                      ^^                                            ".ToCharArray(),
                "                     ^                                              ".ToCharArray(),
                "                    ^^                                              ".ToCharArray(),
                "                  ^^^                                               ".ToCharArray(),
                "                  ^^^                                               ".ToCharArray(),
                "                 ^^^^^^                                             ".ToCharArray(),
                "                  ^^^                                               ".ToCharArray(),
                "                 ^^^                                                ".ToCharArray(),
                "                   ^^                                               ".ToCharArray(),
                "                    ^^                                              ".ToCharArray(),
                "                   ^^^^                                             ".ToCharArray(),
                "                 ^^^^^^                                             ".ToCharArray(),
                "                   ^^^^                                             ".ToCharArray(),
                "                  ^^^^^                                             ".ToCharArray(),
                "                   ^^^^^^                                           ".ToCharArray(),
                "                     ^^^                                            ".ToCharArray(),
                "                       ^^                                           ".ToCharArray(),
                "                        ^                                           ".ToCharArray(),
                "                        ^^^                                         ".ToCharArray(),
                "                          ^^                                        ".ToCharArray(),
                "                           ^                                        ".ToCharArray(),
                "                          ^^                                        ".ToCharArray(),
                "                            ^                                       ".ToCharArray(),
                "                          ^^                                        ".ToCharArray(),
                "                          ^^                                        ".ToCharArray(),
                "                                                                    ".ToCharArray(),
                "                           ^                                        ".ToCharArray(),
                "                         ^^^^                                       ".ToCharArray()
            };

            char[][] volcano =
            {
                "      ^^^^^^^^^      ".ToCharArray(),
                "    ^^^^^^^^^^^^^    ".ToCharArray(),
                "  ^^^^^^^^^^^^^^^^^  ".ToCharArray(),
                " ^^^^^^^     ^^^^^^^ ".ToCharArray(),
                "^^^^^^^       ^^^^^^^".ToCharArray(),
                "^^^^^^^       ^^^^^^^".ToCharArray(),
                "^^^^^^^       ^^^^^^^".ToCharArray(),
                " ^^^^^^^     ^^^^^^^ ".ToCharArray(),
                "  ^^^^^^^^^^^^^^^^^  ".ToCharArray(),
                "    ^^^^^^^^^^^^^    ".ToCharArray(),
                "      ^^^^^^^^^      ".ToCharArray()
            };

            char[][] twins =
            {
                "^^^^^       ".ToCharArray(),
                "^^^^^       ".ToCharArray(),
                "^^^^^       ".ToCharArray(),
                "            ".ToCharArray(),
                "     ^^^^^^^".ToCharArray(),
                "     ^^^^^^^".ToCharArray(),
                "     ^^^^^^^".ToCharArray(),
                "     ^^^^^^^".ToCharArray(),
                "     ^^^^^^^".ToCharArray(),
                "     ^^^^^^^".ToCharArray(),
                "     ^^^^^^^".ToCharArray()
            };

            char[][] plateau =
            {
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^^^^^^^^^^^".ToCharArray()
            };

            char[][] sixth =
            {
                "     ^^^^^^".ToCharArray(),
                " ^^^^^^^^  ".ToCharArray(),
                "^^^^^^^^^  ".ToCharArray(),
                "  ^^^^^^^^ ".ToCharArray(),
                "  ^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^".ToCharArray(),
                "^^^^^^^^^^^".ToCharArray(),
                "  ^^^^^^^^^".ToCharArray(),
                "  ^^^^^^^^ ".ToCharArray(),
                "  ^^^^^^^  ".ToCharArray(),
                "  ^^^^^^   ".ToCharArray(),
                "   ^^^^^^  ".ToCharArray(),
                "    ^^^^^  ".ToCharArray(),
                "      ^^   ".ToCharArray()
            };

            char[][] seventh =
            {
                "^^   ^^^  ^^".ToCharArray(),
                "^ ^^  ^^^   ".ToCharArray(),
                "  ^^^   ^^  ".ToCharArray(),
                "    ^^ ^^   ".ToCharArray(),
                "   ^  ^     ".ToCharArray(),
                "    ^^      ".ToCharArray(),
                " ^^^^^^^^   ".ToCharArray(),
                "  ^^^^^^^^  ".ToCharArray(),
                " ^^ ^^^   ^^".ToCharArray(),
                "^^^    ^^ ^^".ToCharArray(),
                "     ^^^^^^^".ToCharArray()
            };

            Console.WriteLine(PeakHeight(sixth));
        }

        private static int PeakHeight(char[][] mountain)
        {
            var height = 0;

            while (true)
            {
                var mountainsFound = false;
                foreach (var i in mountain)
                    if (i.Contains('^'))
                        mountainsFound = true;

                if (!mountainsFound) break;
                height++;

                for (var i = 0; i < mountain.Length; i++)
                {
                    if (i == 0 || i == mountain.Length - 1)
                    {
                        for (var j = 0; j < mountain[i].Length; j++)
                            if (mountain[i][j] == '^')
                                mountain[i][j] = (char) height;
                        continue;
                    }

                    for (var j = 0; j < mountain[i].Length; j++)
                    {
                        if (mountain[i][j] == ' ') continue;

                        if ((j == mountain[i].Length - 1 || j == 0 || mountain[i][j + 1] == ' ' ||
                             mountain[i][j - 1] == ' ') && mountain[i][j] == '^')
                            mountain[i][j] = (char) height;
                        else if ((mountain[i - 1][j] == ' ' || mountain[i + 1][j] == ' ') && mountain[i][j] == '^')
                            mountain[i][j] = (char) 1;
                        else if ((i > 0 && mountain[i - 1][j] == (char) (height - 1) ||
                                  j > 0 && mountain[i][j - 1] == (char) (height - 1) ||
                                  j != mountain[i].Length - 1 && mountain[i][j + 1] == (char) (height - 1) ||
                                  i != mountain.Length - 1 && mountain[i + 1][j] == (char) (height - 1) ||
                                  j < mountain[i].Length - 1 &&
                                  mountain[i][j + 1] == (char) (height - 1)) &&
                                 mountain[i][j] == '^')
                            mountain[i][j] = (char) height;
                    }
                }
            }

            return height;
        }
    }
}