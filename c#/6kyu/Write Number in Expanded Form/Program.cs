using System;
using System.Collections.Generic;

namespace Write_Number_in_Expanded_Form
{
    internal static class Program
    {
        /*
         * Write Number in Expanded Form
         * https://www.codewars.com/kata/5842df8ccbd22792a4000245/train/csharp
         *
         * You will be given a number and you will need to return it as a string in Expanded Form. For example:
         * Kata.ExpandedForm(12); # Should return "10 + 2"
         * Kata.ExpandedForm(42); # Should return "40 + 2"
         * Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
         */
        private static void Main()
        {
            // Console.WriteLine(ExpandedForm(12));
            // Console.WriteLine(ExpandedForm(42));
            // Console.WriteLine(ExpandedForm(70304));
            Console.WriteLine(ExpandedForm(long.MaxValue));
        }

        private static string ExpandedForm(long num)
        {
            var stack = new Stack<long>();
            long multiplier = 1;

            while (num != 0)
            {
                var temp = num % 10;
                if (temp > 0) stack.Push(temp * multiplier);
                num /= 10;
                multiplier *= 10;
            }

            return string.Join(" + ", stack);;
        }
    }
}