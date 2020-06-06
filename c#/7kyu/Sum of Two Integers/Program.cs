using System;

namespace Sum_of_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 19));
        }

        static int Add(int x, int y)
        {
            while (y != 0)
            {
                var carry = x & y;
                x ^= y;
                y = carry << 1;
            }
            return x;
        }
    }
}
