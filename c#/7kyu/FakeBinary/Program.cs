using System;
using System.Linq;

namespace FakeBinary
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(FakeBin("45385593107843568"));
        }

        private static string FakeBin(string x) =>
            x.Aggregate(string.Empty, (current, t) => current + (char.GetNumericValue(t) < 5 ? "0" : "1"));
    }
}
