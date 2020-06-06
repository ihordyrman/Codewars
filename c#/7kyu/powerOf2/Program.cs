using System;
using System.Linq;
using System.Numerics;

namespace powerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = PowersOfTwo(1);
            for (int i = 0; i < x.Length; i++) Console.WriteLine($"BigInt{i} = {x[i]}");
        }

        private static BigInteger[] PowersOfTwo(int n)
        {
            var arr = new BigInteger[n+1];
            for (var i = 0; i <= n; i++)
            {
                arr[i] = (BigInteger) Math.Pow(2, i);
            }
            return arr;
        }

        private static BigInteger[] AnotherPowersOfTwo(int n) =>
            Enumerable.Range(0, n + 1).Select(x => BigInteger.Pow(2, x)).ToArray();
    }
}
