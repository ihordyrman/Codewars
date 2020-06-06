using System;

namespace Draw_stairs
{
    class Program
    {
        // https://www.codewars.com/kata/draw-stairs/train/csharp
        // Given a number n, draw stairs using the letter "I", n tall and n wide, with the tallest in the top left.

        // For example n = 3 result in "I\n I\n I", or printed:
        //
        // I
        //  I
        //   I
        static void Main(string[] args)
        {
            Console.WriteLine(DrawStairs(5));
        }
        
        public static string DrawStairs(int n)
        {
            var result = "";
            for (int i = 1; i < n; i++)
            {
                result += "I\n" + new string(' ', i);
            }
            
            return result + "I";
        }
    }
}
