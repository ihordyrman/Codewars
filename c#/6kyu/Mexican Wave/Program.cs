using System;
using System.Collections.Generic;
using System.Linq;

namespace Mexican_Wave
{
    /*
     * https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/csharp
     * Mexican Wave
     *
     * In this simple Kata your task is to create a function that turns a string into a Mexican Wave.
     * You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up.
    */
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Wave("hello"));
        }

        private static List<string> Wave(string str) =>
            str.Select((c, i) => str.Substring(0, i) + char.ToUpper(c) + str.Substring(i + 1))
                .Where(x => x != str)
                .ToList();
    }
}