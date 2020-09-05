namespace Hamming_Code
{
    using System;
    using System.Linq;
    using System.Text;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(encode("hey"));
            Console.WriteLine(decode(encode("hey")));
        }

        private static string encode(string text) =>
            string.Concat(Encoding.ASCII.GetBytes(text).Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')))
                .Replace("1", "111")
                .Replace("0", "000");

        private static string decode(string bits)
        {
            var bytes = bits.Replace("000", "0").Replace("111", "1").Select(x => (byte)char.GetNumericValue(x)).ToArray();
            var result = string.Empty;

            for (int i = 0; i < bytes.Length; i += 8)
            {
                byte[] tmp = new[] { bytes[i], bytes[i + 1], bytes[i + 2], bytes[i + 3], bytes[i + 4], bytes[i + 5], bytes[i + 6], bytes[i + 7] };
                result += Encoding.ASCII.GetString(tmp, 0, tmp.Length);
            }

            return result;
        }
    }
}
