using System;

namespace Count_IP_Addresses
{
    /*
        Count IP Addresses
        https://www.codewars.com/kata/526989a41034285187000de4/train/csharp

        Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).
        All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IpsBetween("10.0.0.0", "10.0.0.50")); //   50 
            Console.WriteLine(IpsBetween("10.0.0.0", "10.0.1.0")); //  256 
            Console.WriteLine(IpsBetween("20.0.0.10", "20.0.1.0")); //  246
            Console.WriteLine(IpsBetween("214.30.46.94", "215.15.75.42")); //  15801548
            /*
                215 - 214 = 1 * 256 * 256 * 256 = 16777216
                15 - 30 = -15 * 256 * 256 = -983040
                75 - 46 = 29 * 256 = 7424
                42 - 94 = -52
            */
        }

        private static long IpsBetween(string start, string end)
        {
            if (start == end) return 0L;

            var startarr = start.Split('.');
            var endarr = end.Split('.');

            if (startarr.Length != 4 || endarr.Length != 4)
                return 0L;

            var difference = 0L;

            for (int i = 0; i < startarr.Length; i++)
            {
                if (startarr[i] == endarr[i])
                    continue;

                var tmp = (Convert.ToInt32(endarr[i]) - Convert.ToInt32(startarr[i]));
                
                for (int x = 0; x < 4-i-1; x++)
                {
                    tmp *= 256;
                }

                difference += tmp;
            }

            return difference;
        }
    }
}
