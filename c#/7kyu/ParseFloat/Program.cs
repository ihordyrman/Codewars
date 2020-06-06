using System;

namespace ParseFloat
{
    class Program
    {
        static void Main(string[] args) =>
            Console.WriteLine("Hello World!");

        public static double? ParseF(object s = null) =>
            double.TryParse(s as string, out var x) ? x : (double?) null;
    }
}
