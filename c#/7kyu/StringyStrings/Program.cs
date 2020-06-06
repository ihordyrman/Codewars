using System;
using System.Linq;

namespace StringyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Stringy(1));
            Console.WriteLine(Stringy(3));
            Console.WriteLine(Stringy(10));
        }

        private static string Stringy(int size)
        {
            var result = string.Empty;
            var current = true;
            for (int i = 0; i < size; i++)
            {
                result += Convert.ToInt32(current);
                current = !current;
            }

            return result;
        }

        private static string BetterStringy(int size) =>
            string.Join("", Enumerable.Range(0, size).Select(x => (x + 1) % 2));
    }
}
