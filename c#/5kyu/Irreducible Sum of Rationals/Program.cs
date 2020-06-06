using System;

namespace Irreducible_Sum_of_Rationals
{
    class Program
    {
        // https://www.codewars.com/kata/5517fcb0236c8826940003c9

        // You will have a list of rationals in the form
        // lst = [ [numer_1, denom_1] , ... , [numer_n, denom_n] ]
        // where all numbers are positive integers. You have to produce their sum N / D in an irreducible form:
        // this means that N and D have only 1 as a common divisor.

        // Return the result "[N, D]"
        // If the result is an integer (D evenly divides N) return: "n"
        // If the input list is empty, return null
        static void Main(string[] args)
        {
            SumFractals(new[,] {{1, 2}, {1, 3}, {1, 4}});
        }

        private static string SumFractals(int[,] l)
        {
            // TODO: NOT FINISHED!
            var d = 1;
            var n = 1;
            for (var i = 0; i < l.GetLength(0); i++)
            {
                for (var j = 0; j < l.GetLength(1); j++)
                {
                    n *= (int)l.GetValue(0, j);
                    d *= (int)l.GetValue(1, j);
                    Console.WriteLine(l[i, j]);
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(d);
            return "";
        }
    }
}