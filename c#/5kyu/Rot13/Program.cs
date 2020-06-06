using System;
using System.Linq;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/530e15517bc88ac656000716

            // ROT13 is a simple letter substitution cipher that replaces
            // a letter with the letter 13 letters after it in the alphabet.
            // ROT13 is an example of the Caesar cipher.

            // Create a function that takes a string and returns the string ciphered with Rot13.
            // If there are numbers or special characters included in the string,
            // they should be returned as they are. Only letters from the latin/english
            // alphabet should be shifted, like in the original Rot13 "implementation".
            Console.WriteLine(Rot13("test")); // grfg
            Console.WriteLine(Rot13("Test")); // Grfg
        }

        private static string Rot13(string message)
        {
            var array = message.ToCharArray();
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] >= 97 && array[i] <= 122)
                {
                    if (array[i] + 13 > 122) array[i] = (char) (97 + (12 - (122 - array[i])));
                    else array[i] = (char) (array[i] + 13);
                }
                else if (array[i] >= 65 && array[i] <= 90)
                {
                    if (array[i] + 13 > 90) array[i] = (char) (65 + (12 - (90 - array[i])));
                    else array[i] = (char) (array[i] + 13);
                }
            }

            return new string(array);
        }
    }
}