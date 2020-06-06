using System;
using System.Linq;

namespace Greed_is_Good
{
    class Program
    {
        // https://www.codewars.com/kata/5270d0d18625160ada0000e4

        // Greed is a dice game played with five six-sided dice.
        // Your mission, should you choose to accept it, is to score a throw
        // according to these rules. You will always be given an array with five six-sided dice values.

        // Three 1's => 1000 points
        // Three 6's =>  600 points
        // Three 5's =>  500 points
        // Three 4's =>  400 points
        // Three 3's =>  300 points
        // Three 2's =>  200 points
        // One   1   =>  100 points
        // One   5   =>   50 point

        // A single die can only be counted once in each roll.
        // For example, a "5" can only count as part of a triplet (contributing to the 500 points)
        // or as a single 50 points, but not both in the same roll.

        // Example scoring
        // Throw       Score
        // ---------   ------------------
        // 5 1 3 4 1   50 + 2 * 100 = 250
        // 1 1 1 3 1   1000 + 100 = 1100
        // 2 4 4 5 4   400 + 50 = 450

        // In some languages, it is possible to mutate the input to the function.
        // This is something that you should never do.
        // If you mutate the input, you will not be able to pass all the tests.

        static void Main(string[] args)
        {
            Console.WriteLine(Score(new[] {2, 3, 4, 6, 2})); // 0
            Console.WriteLine(Score(new[] {4, 4, 4, 3, 3})); // 400
            Console.WriteLine(Score(new[] {2, 4, 4, 5, 4})); // 450
        }

        private static int Score(int[] dice)
        {
            var sum = 0;
            foreach (var values in dice.GroupBy(x => x))
            {
                if (values.Count() < 3 && (values.Key == 1 || values.Key == 5))
                    sum = values.Key == 1 ? sum + 100 * values.Count() : sum + 50 * values.Count();
                else if (values.Count() == 3 || values.Count() > 3 && values.Key != 1 && values.Key != 5)
                    sum = values.Key == 1 ? sum + 1000 : sum + values.Key * 100;
                else if (values.Count() > 3 && (values.Key == 1 || values.Key == 5))
                    sum = values.Key == 1 ? sum + 1000 + values.Count() % 3 * 100 : sum + 500 + values.Count() % 3 * 50;
            }
            return sum;
        }
    }
}