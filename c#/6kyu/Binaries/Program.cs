using System;
using System.Globalization;
using System.Linq;

namespace Binaries
{
    static class Program
    {
        // https://www.codewars.com/kata/binaries/train/csharp
        // Let us take a string composed of decimal digits: "10111213".
        // We want to code this string as a string of 0 and 1 and after that be able to decode it.

        // We decompose the given string in its decimal digits 1 0 1 1 1 2 1 3 and we will code each.
        //
        // Coding process to code a number n expressed in base 10:
        // a) Let k be the number of bits of n  
        //
        // b) Put k-1 times the digit 0 followed by the digit 1
        //
        // c) Put number n in binary
        //
        // d) Concat the result of b) and c)
        //
        // So we code 0 as 10, 1 as 11 ... etc...
        //
        // Repeating this process with the initial string
        //
        // "10111213" becomes : "11101111110110110111" resulting of concatenation of 11 10 11 11 11 0110 11 0111 .
        //
        // Task:
        // Given strng a string of digits representing a decimal number
        // the function code(strng) should return the coding of strng as explained above.
        //
        // Given a string strng resulting from the previous coding, decode it to get the corresponding decimal string.
        //
        // Examples:
        // code("77338855") --> "001111 001111 0111 0111 00011000 00011000 001101 001101"
        // code("77338")  --> "001111 001111 0111 0111 00011000"
        // code("0011121314") --> "1010111111011011011111001100"
        //
        // decode("001111001111011101110001100000011000001101001101") -> "77338855"
        // decode("0011110011110111011100011000") -> "77338"
        // decode("1010111111011011011111001100") -> "0011121314"
        // Notes
        // SHELL: The only tested function is decode.
        // Please could you ask before translating : some translations are already written.
        
        //8 - 1bits 1
        private static void Main(string[] args)
        {
            // Console.WriteLine(Convert.ToString(8, 2));
            // Console.WriteLine(CountBits(8)); 

            
            // Console.WriteLine(Code("55337700"));
            // Console.WriteLine(Code("1119441933000055"));
            // Console.WriteLine(Code("69"));
            // Console.WriteLine(Code("86"));
            
            Console.WriteLine(Decode("10001111"));
            // Console.WriteLine(Decode("001100001100001100001110001110001110011101110111001110001110001110001111001111001111001100001100001100"));
            // Console.WriteLine(Decode("01110111110001100100011000000110000011110011110111011100110000110001100110"));
            // Console.WriteLine(Decode("0011010011010011011010101111110011000011000011000011100011100011100011100011100011100001100100011001000110011100011001001111001111001111001111001111001111"));
        }

        private static string Code(string strng)
        {
            var result = "";
            var digits = strng.ToArray().Select(x => int.Parse(x.ToString())).ToArray();
            for (var i = 0; i < digits.Length; i++)
            {
                var bin = Convert.ToString(digits[i], 2);
                Console.WriteLine(Convert.ToInt32(string.Concat(Enumerable.Repeat("0", bin.Length - 1)) + "1" + bin, 2));
                result += Convert.ToInt32(string.Concat(Enumerable.Repeat("0", bin.Length - 1)) + "1" + bin, 2);
            }
            
            return result; 
        }

        private static string Decode(string str)
        {
            var digits = "";
            for (int i = 0, runLength = 1; i < str.Length; i++)
            {
                if (str[i] == '0') runLength++;
                else
                {
                    digits += str.Remove(i + 1, (i + 1 + runLength) - (i+1));
                    i += runLength;
                    runLength = 1;
                }
            }
            return digits;
        }

        private static int CountBits(int value)
        {
            var count = 0;
            while (value != 0)
            {
                count++;
                value &= value - 1;
            }
            return count;
        }
    }
}
