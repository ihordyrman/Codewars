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

        private static string WhatCentury(string year)
        {
            var result = Convert.ToInt32(year) / 100 + (Convert.ToInt32(year) % 100 > 0 ? 1 : 0);
            return result switch
            {
                11 => "11th",
                12 => "12th",
                13 => "13th",
                _ => (result % 10) switch
                {
                    1 => result + "st",
                    2 => result + "nd",
                    3 => result + "rd",
                    _ => result + "th"
                }
            };
        }
    }
}