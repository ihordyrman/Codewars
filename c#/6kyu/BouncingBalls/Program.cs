using System;

namespace BouncingBalls
{
    /*
     * https://www.codewars.com/kata/5544c7a5cb454edb3c000047/train/csharp
     * A child is playing with a ball on the nth floor of a tall building. The height of this floor, h, is known.
     * He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).
     *
     * His mother looks out of a window 1.5 meters from the ground.
     *
     * How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?
     *
     * Three conditions must be met for a valid experiment:
     * Float parameter "h" in meters must be greater than 0
     * Float parameter "bounce" must be greater than 0 and less than 1
     * Float parameter "window" must be less than h.
     * If all three conditions above are fulfilled, return a positive integer, otherwise return -1.
     */
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(BouncingBall(3.0, 0.66, 1.5)); // 3
            Console.WriteLine(BouncingBall(30.0, 0.66, 1.5)); // 15
        }

        private static int BouncingBall(double h, double bounce, double window)
        {
            var count = -1;
            if (h <= 0 || (bounce <= 0 || bounce >= 1) || window >= h) return count;
            while (window < h)
            {
                h *= bounce;
                count += 2;
            }
            return count;
        }
    }
}
