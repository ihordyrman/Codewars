using System;
using System.Text;

namespace Christmas_tree
{
    /*
     * Create a function christmasTree(height) or christmas_tree(height) (in Ruby) that returns a christmas tree of the correct height
     * christmasTree(5) || christmas_tree(height) should return:
     *     *    
     *    ***   
     *   *****  
     *  ******* 
     * *********
     * Height passed is always an integer between 0 and 100.
     * Use \n for newlines between each line.
     * Pad with spaces so each line is the same length. The last line having only stars, no spaces.
     */
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(ChristmasTree(8));
            Console.WriteLine(ChristmasTree(10));
            Console.WriteLine(ChristmasTree(8000));
        }

        private static string ChristmasTree(int height)
        {
            var result = new StringBuilder();

            var starsCount = 1;
            for (var i = 0; i < height; i++)
            {
                var spaces = new string(' ', height - 1 - i);
                result.Append(spaces);
                result.Append(new string('*', starsCount));
                result.Append(spaces);
                starsCount += 2;

                if (height == 1 || i + 1 == height) continue;
                result.Append('\n');
            }

            return result.ToString();
        }
    }
}