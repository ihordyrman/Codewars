using System;

namespace zerosOfN
{
    class Program
    {
        // https://www.codewars.com/kata/52f787eb172a8b4ae1000a34

        // Write a program that will calculate the number of trailing zeros in a factorial of a given number.
        // N! = 1 * 2 * 3 * ... * N
        // Be careful 1000! has 2568 digits...
        // For more info, see: http://mathworld.wolfram.com/Factorial.html

        // Examples
        // zeros(6) = 1
        // # 6! = 1 * 2 * 3 * 4 * 5 * 6 = 720 --> 1 trailing zero

        // zeros(12) = 2
        // # 12! = 479001600 --> 2 trailing zeros
        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(5)); // 1
            Console.WriteLine(TrailingZeros(25)); // 6
            Console.WriteLine(TrailingZeros(531)); // 131
        }

        private static int TrailingZeros(int n)
        {
            var zeros = 0;
            while (n > 0)
            {
                n /= 5;
                zeros += n;
            }
            return zeros;
        }
    }
}