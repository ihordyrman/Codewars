using System;
using System.Numerics;

namespace Perimeter_of_squares_in_a_rectangle
{
    /*
     * https://www.codewars.com/kata/559a28007caad2ac4e000083/train/csharp
     * Perimeter of squares in a rectangle
     *
     * The drawing shows 6 squares the sides of which have a length of 1, 1, 2, 3, 5, 8.
     * It's easy to see that the sum of the perimeters of these squares is :
     * 4 * (1 + 1 + 2 + 3 + 5 + 8) = 4 * 20 = 80
     * Could you give the sum of the perimeters of all the squares in a rectangle
     * when there are n + 1 squares disposed in the same manner as in the drawing
     * The function perimeter has for parameter n where n + 1 is the number of squares
     * (they are numbered from 0 to n) and returns the total perimeter of all the squares.
     */
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Perimeter(new BigInteger(5))); // 80
            Console.WriteLine(Perimeter(new BigInteger(7))); // 216
        }

        private static BigInteger Perimeter(BigInteger n)
        {
            BigInteger n1 = 1, n2 = 1, n3 = n1 + n2, n4 = 2 * n3;

            for (var i = 2; i < n; ++i)
            {
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
                n4 += n3;
            }

            return n4 * 4;
        }
    }
}