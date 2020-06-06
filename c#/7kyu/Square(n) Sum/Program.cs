using System;
using System.Linq;

namespace Square_n__Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareSum(new int[] { 1, 2, 2 }));
            Console.WriteLine(SquareSum(new int[] { 1, 2 }));
            Console.WriteLine(SquareSum(new int[] { 5, 3, 4 }));
        }

        public static int SquareSum(int[] n)
        {
            return n.Sum(x => x * x); 
        }
    }
}
