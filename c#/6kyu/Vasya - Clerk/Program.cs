using System;
using System.Collections.Generic;

namespace Vasya___Clerk
{
    /*
     * The new "Avengers" movie has just been released!
     * There are a lot of people at the cinema box office standing in a huge line.
     * Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.
     * Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
     * Can Vasya sell a ticket to every person and give change if he initially has no money and
     * sells the tickets strictly in the order people queue?
     * Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment.
     * Otherwise return NO.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tickets(new[] {25, 25, 50})); // YES
            Console.WriteLine(Tickets(new[] {25, 100})); // NO
            Console.WriteLine(BetterTickets(new[] {25, 25, 50, 50, 100})); // NO
        }

        private static string BetterTickets(int[] peopleInLine)
        {
            int[] bills = {0, 0, 0};

            foreach (var v in peopleInLine)
            {
                switch (v)
                {
                    case 25:
                        bills[0] += 1;
                        break;
                    case 50:
                        bills[0] -= 1;
                        bills[1] += 1;
                        break;
                    case 100 when bills[1] > 0:
                        bills[0] -= 1;
                        bills[1] -= 1;
                        break;
                    case 100 when bills[1] == 0:
                        bills[0] -= 3;
                        break;
                }

                if (bills[0] < 0 || bills[1] < 0 || bills[2] < 0) return "NO";
            }

            return "YES";
        }

        private static string Tickets(int[] peopleInLine)
        {
            if (peopleInLine.Length == 0 || peopleInLine[0] > 25) return "NO";

            var stock = new Dictionary<int, int>
            {
                {25, 0},
                {50, 0},
            };

            foreach (var t in peopleInLine)
            {
                if (t == 25) stock[25]++;
                else if (t == 50)
                {
                    if (stock[25] == 0)
                        return "NO";

                    stock[25]--;
                    stock[50]++;
                }
                else
                {
                    if (stock[25] >= 3)
                    {
                        stock[25] = -3;
                    }
                    else if (stock[50] > 0 && stock[25] > 0)
                    {
                        stock[25] = -1;
                        stock[50] = -1;
                    }
                    else return "NO";

                    stock[50]++;
                }
            }

            return "YES";
        }
    }
}