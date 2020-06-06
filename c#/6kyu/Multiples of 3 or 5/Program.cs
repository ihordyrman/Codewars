using System;
using System.Linq;

namespace Multiples_of_3_or_5
{
    class Program
    {
        // https://www.codewars.com/kata/multiples-of-3-or-5/train/csharp
        
        // If we list all the natural numbers below 10 that are multiples of 3 or 5,
        // we get 3, 5, 6 and 9. The sum of these multiples is 23.

        // Finish the solution so that it returns the sum of all
        // the multiples of 3 or 5 below the number passed in.
        
        // Note: If the number is a multiple of both 3 and 5, only count it once.
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
            Console.WriteLine(BetterSolution(34));
        }

        private static int Solution(int value)
        {
            var sum = 0;
            for (var i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static int BetterSolution(int value)
        {
            return Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
