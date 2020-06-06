using System;

namespace Grasshopper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckForFactor(10,2));
        }

        private static bool CheckForFactor(int num, int factor)
        {
            return num % factor == 0;
        }
    }
}
