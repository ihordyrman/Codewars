using System;

namespace get_ascii_value_of_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Kata
    {
        public static int GetASCII(char c)
        {
            return Convert.ToInt16(c);
        }
    }
}
