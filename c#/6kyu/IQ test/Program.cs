using System;
using System.Collections.Generic;
using System.Linq;

namespace IQ_test
{
    // https://www.codewars.com/kata/552c028c030765286c00007d/train/csharp
    
    // Bob is preparing to pass IQ test.
    // The most frequent task in this test is to find out which one of the given numbers
    // differs from the others. Bob observed that one number usually differs from the
    // others in evenness. Help Bob — to check his answers, he needs a program that among
    // the given numbers finds one that is different in evenness, and return a position of this number.

    // ! Keep in mind that your task is to help Bob solve a real IQ test,
    // which means indexes of the elements start from 1 (not 0)
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("2 4 7 8 10")); // 3
            Console.WriteLine(Test("1 2 2")); // 1
        }

        private static int Test(string numbers)
        {
            var isOdds = numbers.Split(' ').Select(t => int.Parse(t) % 2 != 0).ToList();
            return isOdds.IndexOf(isOdds.Count(x => x) == 1) + 1;
        }
    }
}
