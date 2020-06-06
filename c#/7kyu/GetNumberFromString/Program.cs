using System;
using System.Linq;

namespace GetNumberFromString
{
    internal static class Program
    {
        private static void Main(string[] args) =>
            Console.WriteLine(GetNumberFromString("hell5o wor6ld"));

        private static int GetNumberFromString(string s) =>
            Convert.ToInt32(s.Where(ch => ch > 47 && ch < 58)
                .Aggregate(string.Empty, (current, ch) => current + ch));
    }
}
