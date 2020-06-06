using System;

namespace RGB_To_Hex_Conversion
{
    class Program
    {
        // https://www.codewars.com/kata/513e08acc600c94f01000001/

        // The rgb() method is incomplete.
        // Complete the method so that passing in RGB decimal values will
        // result in a hexadecimal representation being returned.
        // The valid decimal values for RGB are 0 - 255. Any (r,g,b) argument values
        // that fall out of that range should be rounded to the closest valid value.

        // The following are examples of expected output values:
        // Rgb(255, 255, 255) # returns FFFFFF
        // Rgb(255, 255, 300) # returns FFFFFF
        // Rgb(0,0,0) # returns 000000
        // Rgb(148, 0, 211) # returns 9400D3
        static void Main(string[] args)
        {
            Console.WriteLine(Rgb(255, 255, 255));
            Console.WriteLine(Rgb(255, 255, 300));
            Console.WriteLine(Rgb(0, 0, 0));
            Console.WriteLine(Rgb(148, 0, 211));
            Console.WriteLine(Rgb(148, -20, 211));
            Console.WriteLine(Rgb(144, 195, 212));
            Console.WriteLine(Rgb(212, 53, 12));
        }

        private static string Rgb(int r, int g, int b)
        {
            int[] rgbs = {r, g, b};
            var result = "";
            foreach (var rgb in rgbs)
            {
                if (rgb > 255)
                {
                    result += "FF";
                    continue;
                }

                if (rgb < 0)
                {
                    result += "00";
                    continue;
                }

                var firstValue = rgb / 16;
                var secondValue = rgb % 16;

                result += firstValue < 10 ? $"{firstValue}" : GetHex(firstValue);
                result += secondValue < 10 ? $"{firstValue}" : GetHex(secondValue);
            }

            return result;
        }

        private static string GetHex(int value) => value switch
        {
            10 => "A",
            11 => "B",
            12 => "C",
            13 => "D",
            14 => "E",
            _ => "F"
        };

        private static string BetterRgb(int r, int g, int b) =>
            $"{Math.Max(Math.Min(255, r), 0):X2}" +
            $"{Math.Max(Math.Min(255, g), 0):X2}" +
            $"{Math.Max(Math.Min(255, b), 0):X2}";
    }
}