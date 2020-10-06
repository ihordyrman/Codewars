using System;
using System.Linq;

namespace Simple_time_difference
{
    internal static class Program
    {
        private static void Main()
        {
            // Console.WriteLine(Solve(new[] {"14:51", "14:51"})); // "23:59"
            // Console.WriteLine(Solve(new[] {"21:14", "15:34", "14:51", "06:25", "15:30"})); // "09:10"
            Console.WriteLine(Solve(new[] {"23:00", "04:22", "18:05", "06:24"})); // "11:40"
        }

        private static string Solve(string[] arr)
        {
            var list = arr
                .Select(x => int.Parse(x.Substring(0, 2)) * 60 + int.Parse(x.Substring(3)))
                .OrderBy(x => x)
                .ToList();

            list.Add(list[0] + 24 * 60);
            var max = 0;
            for (var i = 1; i < list.Count; i++)
            {
                var diff = list[i] - list[i - 1] - 1;
                max = max < diff ? diff : max;
            }

            return $"{max / 60:D2}:{max % 60:D2}";
        }
    }
}