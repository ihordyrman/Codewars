using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unary_Messages
{
    class Program
    {
        // Binary with 0 and 1 is good, but binary with only 0 is even better!
        // Originally, this is a concept designed by Chuck Norris to send so called unary messages.

        // Can you write a program that can send and receive this messages?
        // Rules
        // The input message consists of ASCII characters between 0 and 100 (7-bit)
        // The encoded output message consists of blocks of 0
        // A block is separated from another block by a space
        // Two consecutive blocks are used to produce a series of same value bits (only 1 or 0 values):
        //     First block is always 0 or 00. If it is 0, then the series contains 1, if not, it contains 0
        //     The number of 0 in the second block is the number of bits in the series
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString('C', 2));
            Console.WriteLine(Convert.ToString('-', 2));
            Console.WriteLine(Convert.ToString('Z', 2));
            Console.WriteLine(Send("CC"));
            Console.WriteLine(Receive("0 0 00 0000 0 000 00 0000 0 00"));
        }

        private static string Send(string text)
        {
            var result = "";
            var binaryString = "";
            foreach (var c in text.ToCharArray())
            {
                binaryString += Convert.ToString(c, 2);
            }

            var current = ' ';
            foreach (var c in binaryString)
            {
                if (current != c)
                {
                    current = c;
                    result += c == '0' ? " 00 0" : " 0 0";
                    continue;
                }

                result += "0";
            }

            return result.Trim();
        }

        private static string Receive(string text)
        {
            var binaryString = "";
            while (text.Length > 0)
            {
                var number = 0;
                if (text[0] == '0' && text[1] == '0')
                {
                    text = text.Substring(3, text.Length - 3);
                    number = 0;
                }

                if (text[0] == '0' && text[1] == ' ')
                {
                    text = text.Substring(2, text.Length - 2);
                    number = 1;
                }

                while (text.Length > 0 && text[0] != ' ')
                {
                    text = text.Substring(1, text.Length - 1);
                    binaryString += number;
                }

                if (text.Length > 0) text = text.Substring(1, text.Length - 1);
            }
            
            var sb = new StringBuilder();
            while (binaryString.Length > 0)
            {
                var block = binaryString.Substring(0, 8);
                binaryString = binaryString.Substring(8);
                var value = 0;
                foreach (int x in block)
                {
                    var temp = x - 48;
                    value = (value << 1) | temp;
                }
                sb.Append(Convert.ToChar(value));
            }
            return sb.ToString();
        }
    }
}