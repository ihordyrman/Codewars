using System;

namespace Schrodingers_Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Kata
    {
        private static bool x = false;
        public static bool omnibool => x != !x;
    }
}