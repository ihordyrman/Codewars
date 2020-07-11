using System;
using System.Collections.Generic;
using System.Linq;

namespace Double_Cola
{
    /*
     * Double Cola
     * https://www.codewars.com/kata/551dd1f424b7a4cdae0001f0/train/csharp
     *
     * Sheldon, Leonard, Penny, Rajesh and Howard are in the queue for a "Double Cola" drink vending machine;
     * there are no other people in the queue. The first one in the queue (Sheldon) buys a can, drinks it and doubles!
     * The resulting two Sheldons go to the end of the queue. Then the next in the queue (Leonard) buys a can,
     * drinks it and gets to the end of the queue as two Leonards, and so on.
     *
     * For example, Penny drinks the third can of cola and the queue will look like this:
     * Rajesh, Howard, Sheldon, Sheldon, Leonard, Leonard, Penny, Penny
     *
     * Write a program that will return the name of the person who will drink the n-th cola.
     *
     * The input data consist of an array which contains at least 1 name,
     * and single integer n which may go as high as the biggest number your language of choice supports (if there's such limit, of course).
     * Return the single line — the name of the person who drinks the n-th can of cola. The cans are numbered starting from 1.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[] {"Sheldon", "Leonard", "Penny", "Rajesh", "Howard"};
            Console.WriteLine(WhoIsNext(names, 1));
            Console.WriteLine(WhoIsNext(names, 52));
            Console.WriteLine(SuperSimpleWhoIsNext(names, 7230702951));
        }

        private static string WhoIsNext(string[] names, long n)
        {
            if (n <= names.Length)
            {
                return names[n - 1];
            }

            var x = 0;

            while (5 * (long) Math.Pow(2, x + 1) < n + 5)
            {
                x++;
            }

            var sets = 5 * (long) Math.Pow(2, x);

            var queue = n + 5 - sets;

            var position = (queue - 1) / (sets / names.Length);

            return names[position];
        }

        private static string SuperSimpleWhoIsNext(string[] names, long n)
        {
            var i = n - 1;
            while (i >= names.Length) i = (i - names.Length) / 2;
            return names[i];
        }
    }
}