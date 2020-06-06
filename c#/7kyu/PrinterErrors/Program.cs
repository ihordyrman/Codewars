using System;
using System.Linq;

namespace PrinterErrors
{
    static class Program
    {
        static void Main(string[] args)
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Console.WriteLine(PrinterError(s)); // 3/56
        }

        private static string PrinterError(string s) => $"{s.Count(t => t < 97 || t > 109)}/{s.Length}";
    }
}
