using System;

namespace Tortoise_racing
{
    /*
     * Tortoise racing
     * https://www.codewars.com/kata/55e2adece53b4cdcb900006c/train/csharp
     *
     * Two tortoises named A and B must run a race. A starts with an average speed of 720 feet per hour.
     * Young B knows she runs faster than A, and furthermore has not finished her cabbage.
     * When she starts, at last, she can see that A has a 70 feet lead but B's speed is 850 feet per hour.
     * How long will it take B to catch A?
     *
     * More generally: given two speeds v1 (A's speed, integer > 0) and v2 (B's speed, integer > 0)
     * and a lead g (integer > 0) how long will it take B to catch A?
     * The result will be an array [hour, min, sec] which is the time needed in hours, minutes and seconds
     * (round down to the nearest second) or a string in some languages.
     *
     * If v1 >= v2 then return nil, nothing, null,
     * None or {-1, -1, -1} for C++, C, Go, Nim, [] for Kotlin or "-1 -1 -1".
     */
    class Program
    {
        static void Main(string[] args)
        {
            var race1 = Race(720, 850, 70); // 0, 32, 18
            var race2 = Race(80, 91, 37); // 3, 21, 49
            var race3 = Race(80, 100, 40); // 2, 0, 0
        }

        private static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;
            var time = TimeSpan.FromSeconds(g * 3600.0 / (v2 - v1));
            return new[] {time.Hours, time.Minutes, time.Seconds};
        }
    }
}