using System;
using System.Linq;

namespace Calculate_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindAverage(new double[] {17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16}));
        }

        private static double FindAverage(double[] array)
        {
            return array.Length > 0 ? array.Average() : 0;
        }
    }
}
