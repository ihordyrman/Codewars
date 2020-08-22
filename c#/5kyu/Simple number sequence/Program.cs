using System;
using System.Numerics;

namespace Simple_number_sequence
{
    /*
     * Simple number sequence
     * https://www.codewars.com/kata/5a28cf591f7f7019a80000de/train/csharp
     *
     * In this Kata, you will be given a string of numbers in sequence and your task will be to return the Missing number.
     * If there is no number Missing or there is an error in the sequence, return -1.
     *
     * The sequence will always be in ascending order.
     * More examples in the test cases.
     */
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Missing("123567")); // 4
            Console.WriteLine(Missing("899091939495")); // 92
            Console.WriteLine(Missing("9899101102")); // 100
            Console.WriteLine(Missing("599600601602")); // -1
            Console.WriteLine(Missing("8990919395")); // -1
            Console.WriteLine(Missing("998999100010011003")); // 1002
            Console.WriteLine(Missing("99991000110002")); // 10000
            Console.WriteLine(Missing("979899100101102")); // -1
            Console.WriteLine(Missing("900001900002900004900005900006")); // 900003
            Console.WriteLine(Missing("9000345234523450194352345234500235234500290000490342523542345234523452345234500059000066245634262456425624562456245624562456245666666666666666666666666652462456245625462456")); // 900003
        }

        private static int Missing(string s)
        {
            if (s == string.Empty) return -1;
            if (s.Length == 1) return s[0];

            var digits = 1;
            while (digits <= s.Length / 2)
            {
                var missingCount = 0;
                var missingValue = BigInteger.Zero;

                for (var i = 0; i < s.Length - digits; i += digits)
                {
                    var current = BigInteger.Parse(s.Substring(i, digits));
                    var next = BigInteger.Parse(s.Substring(i + digits, digits));
                    var increased = false;

                    if (current.ToString().Length != (current + 1).ToString().Length)
                    {
                        next = BigInteger.Parse(s.Substring(i + digits, digits + 1));
                        increased = true;
                    }

                    if (next - current == 2)
                    {
                        switch (missingCount)
                        {
                            case 0:
                                missingValue = current + 1;
                                missingCount++;
                                break;
                            default:
                                return -1;
                        }

                        continue;
                    }

                    if (next - current != 1)
                        break;

                    if (increased)
                    {
                        i--;
                        digits++;
                    }
                }

                if (missingValue != 0)
                    return (int)missingValue;

                digits++;
            }

            return -1;
        }
    }
}