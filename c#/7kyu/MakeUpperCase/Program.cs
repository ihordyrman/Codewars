using System;
using System.Linq;

namespace MakeUpperCase
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MakeUpperCase(1));
            Console.WriteLine(MakeUpperCase("1"));
            var x = new[] {1, 2, 3, 4};
            var y = x.Select(z => z).Where(z => z % 2 == 0);
            foreach (var i in y) Console.WriteLine(i);
        }

        private static string MakeUpperCase(string stringValue) => stringValue.ToUpper();

        private static string MakeUpperCase(int intValue) => intValue.ToString().ToUpper();
    }
}
