using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotate_for_a_Max
{
    class Program
    {
        // https://www.codewars.com/kata/56a4872cbb65f3a610000026/train/csharp
        // Let us begin with an example:

        // Take a number: 56789. Rotate left, you get 67895. 
        //
        // Keep the first digit in place and rotate left the other digits: 68957.
        //
        // Keep the first two digits in place and rotate the other ones: 68579.
        //
        // Keep the first three digits and rotate left the rest: 68597.
        // Now it is over since keeping the first four it remains only one digit which rotated is itself.
        
        // You have the following sequence of numbers:

        // 56789 -> 67895 -> 68957 -> 68579 -> 68597
        //
        // and you must return the greatest: 68957.
        //
        // Task
        // Write function max_rot(n) which given a positive integer n returns
        // the maximum number you got doing rotations similar to the above example.
        static void Main(string[] args)
        {
            Console.WriteLine(MaxRot(56789)); // 56789 -> 67895 -> 68957 -> 68579 -> 68597
            // 56789 67895 68957 68579 
            // Console.WriteLine(MaxRot(195881031));
            // Console.WriteLine(MaxRot(896219342));
            // Console.WriteLine(MaxRot(69418307));
            // Console.WriteLine(MaxRot(56789));
            
        }
        
        public static long MaxRot (long n)
        {
            List<long> results = new List<long>();
            string number = n.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                results.Add(long.Parse(number));
                var temp = number[i];
                var removed = number.Remove(i, 1);
                number = $"{removed}{temp}";
            }
            
            return results.Max();
        }
    }
}
