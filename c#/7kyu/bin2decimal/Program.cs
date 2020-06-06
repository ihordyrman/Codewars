using System;

namespace bin2decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinToDec("0"));
            Console.WriteLine(BinToDec("1"));
            Console.WriteLine(BinToDec("10"));
            Console.WriteLine(BinToDec("11"));
            Console.WriteLine(BinToDec("101"));
        }

        private static int BinToDec(string s) => Convert.ToInt32(s, 2);
    }
}
