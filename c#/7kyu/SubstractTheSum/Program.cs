using System;
using System.Linq;

namespace SubstractTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string SubtractSum(int number)
        {
            while (true)
            {
                var chars = number.ToString().ToCharArray();
                var sum = chars.Sum(t => (int) char.GetNumericValue(t));
                if (number < 1 || number > 100) number -= sum;
                else break;
            }

            return null;
        }
    }
}
