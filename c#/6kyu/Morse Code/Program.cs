using System;
using System.Collections.Generic;
using System.Linq;

namespace Morse_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(MorseCodeDecoder.Decode("     ...---... -.-.--   - .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --. .-.-.-  "));
        }
    }

    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            return string.Concat(morseCode.Trim().Replace("   ", " s ").Split().Select(x => x = MorseCode.Get(x)));
        }
    }

    public class MorseCode
    {
        private static Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            {".", "E"},
            {"-", "T"},
            {"s", " "},
            {"..", "I"},
            {".-", "A"},
            {"--", "M"},
            {"-.", "N"},
            {"...", "S"},
            {"..-", "U"},
            {".-.", "R"},
            {".--", "W"},
            {"---", "O"},
            {"-.-", "K"},
            {"-..", "D"},
            {"--.", "G"},
            {"....", "H"},
            {"...-", "V"},
            {"..-.", "F"},
            {".-..", "L"},
            {".--.", "P"},
            {".---", "J"},
            {"-...", "B"},
            {"-..-", "X"},
            {"-.-.", "C"},
            {"-.--", "Y"},
            {"--..", "Z"},
            {"--.-", "Q"},
            {"-.-.--", "!"},
            {".-.-.-", "."},
            {"...---...", "SOS"}
        };

        public static string Get(string letter)
        {
            return dic[letter];
        }
    }
}
