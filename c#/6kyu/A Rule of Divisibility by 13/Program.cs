using System;
using System.Collections.Generic;

namespace A_Rule_of_Divisibility_by_13
{
    /*
     * https://www.codewars.com/kata/564057bc348c7200bd0000ff
     * When you divide the successive powers of 10 by 13 you get the following remainders of the integer divisions:
     *
     * 1, 10, 9, 12, 3, 4.
     *
     * Then the whole pattern repeats.
     *
     * Hence the following method: 
     * Multiply the right most digit of the number with the left most number in the sequence shown above, 
     * the second right most digit to the second left most digit of the number in the sequence. 
     * The cycle goes on and you sum all these products. Repeat this process until the sequence of sums is stationary.
     */
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Thirteen(1234567)); // 87
            Console.WriteLine(Thirteen(8529)); // 79
            Console.WriteLine(Thirteen(85299258)); // 31
            Console.WriteLine(Thirteen(5634)); // 57
            Console.WriteLine(CleanerThirteen(321)); // 48
            Console.WriteLine(CleanerThirteen(1111111111)); // 71
            Console.WriteLine(CleanerThirteen(987654321)); // 30
        }

        private static long Thirteen(long n)
        {
            var remainders = new[] {1, 10, 9, 12, 3, 4};
            var sum = n;
            var temp = 0;
            var numbers = new List<int>();
            var index = 0;

            while (sum != temp)
            {
                while (n > 0)
                {
                    var x = (int) (n % 10);
                    numbers.Add(x);
                    n /= 10;
                }

                foreach (var number in numbers)
                {
                    if (index >= remainders.Length) index = 0;
                    temp += number * remainders[index];
                    index++;
                }

                if (temp == sum)
                    break;

                sum = temp;
                n = temp;
                temp = 0;
                index = 0;
                numbers.Clear();
            }

            return sum;
        }

        private static long CleanerThirteen(long n)
        {
            long[] remainders = {1, 10, 9, 12, 3, 4};
            long sum = 0;

            for (var i = 0; n > 0; i++)
            {
                if (i == remainders.Length) i = 0;
                sum += n % 10 * remainders[i];
                n /= 10;
            }

            return sum > 99 ? CleanerThirteen(sum) : sum;
        }
    }
}