using System;
using System.Linq;

namespace Sum_of_Digits_Digital_Root
{
    class Program
    {
        // https://www.codewars.com/kata/sum-of-digits-slash-digital-root/train/csharp
        // In this kata, you must create a digital root function.

        // A digital root is the recursive sum of all the digits in a number.
        // Given n, take the sum of the digits of n.
        // If that value has more than one digit, continue reducing in this way until
        // a single-digit number is produced. This is only applicable to the natural numbers.
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(942));
            Console.WriteLine(MoreCleverDigitalRoot(942));
            Console.WriteLine(RecursionDigitalRoot(942));
            Console.WriteLine(941 % 9);
        }

        private static int DigitalRoot(long n)
        {
            while (true)
            {
                var sum = 0;
                if (n <= 9) return sum;
                sum = n.ToString().Sum(ch => int.Parse(ch.ToString()));
                if (sum <= 9) return sum;
                n = sum;
            }
        }
        
        private static int RecursionDigitalRoot(long n)
        {
            var sum = 0;
            if (n <= 9) return sum;
            sum = n.ToString().Sum(ch => int.Parse(ch.ToString()));
            return sum > 9 ? DigitalRoot(sum) : sum;
        }

        private static int MoreCleverDigitalRoot(long n)
        {
            return (int) (1 + (n - 1) % 9);
        }
    }
}