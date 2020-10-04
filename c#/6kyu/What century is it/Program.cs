using System;

namespace What_century_is_it
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(WhatCentury("1999")); // 20
            Console.WriteLine(WhatCentury("2011")); // 21
            Console.WriteLine(WhatCentury("2154")); // 22
            Console.WriteLine(WhatCentury("2259")); // 23
        }

        private static string WhatCentury(string year) =>
            (Convert.ToInt32(year) / 100 + (Convert.ToInt32(year) % 100 > 0 ? 1 : 0)) switch
            {
                13 => "13th",
                11 => "11th",
                _ => ((Convert.ToInt32(year) / 100 + (Convert.ToInt32(year) % 100 > 0 ? 1 : 0)) % 10) switch
                {
                    1 => Convert.ToInt32(year) / 100 + (Convert.ToInt32(year) % 100 > 0 ? 1 : 0) + "st",
                    2 => Convert.ToInt32(year) / 100 + (Convert.ToInt32(year) % 100 > 0 ? 1 : 0) + "nd",
                    3 => Convert.ToInt32(year) / 100 + (Convert.ToInt32(year) % 100 > 0 ? 1 : 0) + "rd",
                    _ => Convert.ToInt32(year) / 100 + (Convert.ToInt32(year) % 100 > 0 ? 1 : 0) + "th"
                }
            };
    }
}