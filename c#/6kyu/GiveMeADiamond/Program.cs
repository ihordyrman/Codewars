using System;
using System.Text;

namespace GiveMeADiamond
{
    class Program
    {
        /*
         * Give me a Diamond
         * https://www.codewars.com/kata/5503013e34137eeeaa001648/train/csharp
         *
         * Jamie is a programmer, and James' girlfriend.
         * She likes diamonds, and wants a diamond string from James.
         * Since James doesn't know how to make this happen, he needs your help.
         *
         * Task
         * You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters.
         * Trailing spaces should be removed, and every line must be terminated with a newline character (\n).
         * Return null/nil/None/... if the input is an even number or negative,
         * as it is not possible to print a diamond of even or negative size.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(Print(5));
            Console.WriteLine(Print(7));
            Console.WriteLine(Print(25));
            Console.WriteLine(Print(15));
            Console.WriteLine(Print(9));
            Console.WriteLine(Print(8));


            // "  *\n" " ***\n" "*****\n" " ***\n" "  *\n"
        }

        private static string Print(int n)
        {
            if (n <= 0 || n % 2 == 0) return null;
            var result = new string('*', n) + '\n';
            var stars = n - 2;
            for (var i = 1; i < n / 2 + 1; i++)
            {
                result += new string(' ', i);
                result += new string('*', stars) + '\n';
                result = new string(' ', i)
                    + new string('*', stars)
                    + '\n'
                    + result;
                stars -= 2;
            }

            return result;
        }
    }
}