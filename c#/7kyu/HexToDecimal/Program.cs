using System;
using System.Globalization;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HexToDec("1"));
            Console.WriteLine(HexToDec("a"));
            Console.WriteLine(HexToDec("10"));
            Console.WriteLine(HexToDec("FF"));
            Console.WriteLine(HexToDec("-C"));
        }

        private static double HexToDec(string hexString) =>
            hexString.Contains("-")
                ? -double.Parse(hexString.Replace("-", ""), NumberStyles.HexNumber)
                : double.Parse(hexString, NumberStyles.HexNumber);
    }
}
