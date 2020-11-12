using System;

namespace Which_x_for_that_sum
{
    // https://www.codewars.com/kata/5b1cd19fcd206af728000056/train/csharp
    // Consider the sequence U(n, x) = x + 2x**2 + 3x**3 + .. + nx**n where x is a real number and n a positive integer.
    // When n goes to infinity and x has a correct value (ie x is in its domain of convergence D), U(n, x) goes to a finite limit m depending on x.
    // Usually given x we try to find m. Here we will try to find x (x real, 0 < x < 1) when m is given (m real, m > 0).
    // Let us call solve the function solve(m) which returns x such as U(n, x) goes to m when n goes to infinity.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(2.0)); // 0.5
            Console.WriteLine(Solve(8.0)); // 0.7034648345913732
        }

        private static double Solve(double m) => (2d * m + 1d - Math.Sqrt(4d * m + 1d)) / 2d / m;
    }
}