using System;
using System.Numerics;

namespace A_disguised_sequence
{
    // A disguised sequence (I)
    // Given u0 = 1, u1 = 2 and the relation 6unun+1-5unun+2+un+1un+2 = 0 calculate un for any integer n >= 0.
    // fcn(n) returns un: fcn(17) -> 131072, fcn(21) -> 2097152
    // You can take two points of view to do this kata:
    // the first one purely algorithmic from the definition of un
    // the second one - not at all mandatory, but as a complement - is to get a bit your head around and find which sequence is hidden behind un.
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Fcn(17));
            Console.WriteLine(Fcn(21));
            Console.WriteLine(Fcn(14));
            Console.WriteLine(Fcn(43));
            Console.WriteLine(Fcn(19));
        }

        private static BigInteger Fcn(int n)
        {
            return new BigInteger(Math.Pow(2.0, n));
        }
    }
}
