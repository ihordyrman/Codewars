using System;

namespace int32_to_IPv4
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(UInt32ToIP(2154959208));
            Console.WriteLine(UInt32ToIP(0));
            Console.WriteLine(CleverUInt32ToIP(2149583361));
        }

        private static string UInt32ToIP(uint ip) =>
            System.Net.IPAddress.Parse(ip.ToString()).ToString();

        private static string CleverUInt32ToIP(uint ip) =>
            ((ip & 0xFF000000) >> 24) + "." + ((ip & 0x00FF0000) >> 16) + "." + ((ip & 0x0000FF00) >> 8) + "." + (ip & 0x000000FF);
    }
}
