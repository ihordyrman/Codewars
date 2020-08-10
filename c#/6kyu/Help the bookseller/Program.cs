using System;
using System.Collections.Generic;
using System.Linq;

namespace Help_the_bookseller
{
    /*
     * A bookseller has lots of books classified in 26 categories labeled A, B, ... Z.
     * Each book has a code c of 3, 4, 5 or more characters.
     * The 1st character of a code is a capital letter which defines the book category.
     * In the bookseller's stocklist each code c is followed by a space and by a positive integer n
     * (int n >= 0) which indicates the quantity of books of this code in stock.
     *
     * For example an extract of a stocklist could be:
     * L = {"ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"}.
     * L = ["ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"] or ....
     *
     * You will be given a stocklist (e.g. : L) and a list of categories in capital letters e.g :
     * M = {"A", "B", "C", "W"}
     * M = ["A", "B", "C", "W"] or ...
     */
    class Program
    {
        static void Main(string[] args)
        {
            var art = new[] {"ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600"};
            var cd = new[] {"A", "B", "W"};
            Console.WriteLine(StockSummary(art, cd)); // (A : 200) - (B : 1140) - (W : 0)
        }

        private static string StockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        {
            var dic = new Dictionary<string, int>();
            var result = new List<string>();
            var emptyCount = 0;

            foreach (var t in lstOfArt)
            {
                var stock = t.Split();
                if (!dic.TryAdd(stock[0][0] + "", int.Parse(stock[1])))
                    dic[stock[0][0] + ""] += int.Parse(stock[1]);
            }

            foreach (var s in lstOf1stLetter)
            {
                if (dic.All(x => x.Key != s))
                {
                    result.Add($"({s} : 0)");
                    emptyCount++;
                }
                else
                    result.Add($"({s} : {dic[s]})");
            }

            return emptyCount == lstOf1stLetter.Length
                ? string.Empty
                : string.Join(" - ", result);
        }
    }
}