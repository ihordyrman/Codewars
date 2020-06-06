using System;
using System.Linq;

namespace MaxLengthDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new[] {"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
            var s2 = new[] {"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};

            Console.WriteLine(Mxdiflg(s1, s2));
        }

        private static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0) return -1;
            var result = 0;
            for (var i = 0; i < a1.Length; i++)
            {
                for (var j = 0; j < a2.Length; j++)
                {
                    var absolute = Math.Abs(a1[i].Length - a2[j].Length);
                    result = result < absolute ? absolute : result;
                }
            }

            return result;
        }

        private static int LinqMxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0) return -1;
            return a1.Aggregate(0, (current, t1) => a2.Select(t => Math.Abs(t1.Length - t.Length))
                .Concat(new[] {current}).Max());
        }

        private static int CleverMxdiflg(string[] a1, string[] a2) =>
            a1.Length == 0 || a2.Length == 0
                ? -1
                : Math.Max(a1.Max(s => s.Length) - a2.Min(s => s.Length),
                    a2.Max(s => s.Length) - a1.Min(s => s.Length));
    }
}
