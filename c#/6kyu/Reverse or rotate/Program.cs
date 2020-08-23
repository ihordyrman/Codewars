using System;
using System.Linq;

namespace Reverse_or_rotate
{
    internal class Program
    {
        /*
         * Reverse or rotate?
         * https://www.codewars.com/kata/56b5afb4ed1f6d5fb0000991/train/csharp
         *
         * The input is a string str of digits.
         * Cut the string into chunks (a chunk here is a substring of the initial string) of size sz
         * (ignore the last chunk if its size is less than sz).
         *
         * If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2,
         * reverse that chunk; otherwise rotate it to the left by one position.
         * Put together these modified chunks and return the result as a string.
         *
         * If
         * sz is <= 0 or if str is empty return ""
         * sz is greater (>) than the length of str it is impossible to take a chunk of size sz hence return "".
         */
        private static void Main()
        {
            Console.WriteLine(RevRot("123456987654", 6)); // "234561876549"
            Console.WriteLine(RevRot("123456987653", 6)); // "234561356789"
            Console.WriteLine(RevRot("66443875", 4)); //  "44668753"
            Console.WriteLine(RevRot("66443875", 8)); // "64438756"
            Console.WriteLine(RevRot("664438769", 8)); // "67834466"
            Console.WriteLine(RevRot("123456779", 8)); // "23456771"
            Console.WriteLine(RevRot("", 8)); // ""
            Console.WriteLine(RevRot("123456779", 0)); // ""
            Console.WriteLine(RevRot("563000655734469485", 4)); // "0365065073456944"
            Console.WriteLine(RevRot("733049910872815764", 5)); // "330479108928157"
        }

        private static string RevRot(string strng, int sz)
        {
            if (sz <= 0 || strng == null || strng == string.Empty || sz > strng.Length)
                return string.Empty;

            var result = string.Empty;
            var len = strng.Length - strng.Length % sz;
            for (var i = 0; i < len; i += sz)
            {
                var value = strng.Substring(i, sz);
                var nums = new int[sz];
                for (var j = 0; j < nums.Length; j++)
                    nums[j] = (int) char.GetNumericValue(value[j]);

                switch (nums.Sum(x => Math.Pow(x, 3)) % 2)
                {
                    case 0:
                        Array.Reverse(nums);
                        break;
                    default:
                    {
                        var temp = nums[0];
                        for (var j = 0; j < nums.Length - 1; j++) 
                            nums[j] = nums[j + 1];

                        nums[^1] = temp;
                        break;
                    }
                }

                result += string.Join("", nums);
            }

            return result;
        }
    }
}