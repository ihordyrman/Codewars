using System;

namespace Interlaced_Spiral_Cipher
{
    // In this kata, your task is to implement what I call Interlaced Spiral Cipher (ISC).
    // Encoding a string using ISC is achieved with the following steps:
    // 1. Form a square large enough to fit all the string characters
    // 2. Starting with the top-left corner, place string characters in the corner cells moving in a clockwise direction
    // 3. After the first cycle is complete, continue placing characters in the cells following the last one in its respective row/column
    // 4. When the outer cells are filled, repeat steps 2 through 4 for the remaining inner squares (refer to the example below for further clarification)
    // 5. Fill up any unused cells with a space character and return the rows joined together.
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encode("Hello World!"));
        }

        public static string Encode(string s)
        {
            // Form a square large enough to fit all the string characters

            // Starting with the top-left corner, place string characters in the corner cells moving in a clockwise direction

            // After the first cycle is complete, continue placing characters in the cells following the last one in its respective row/column

            // When the outer cells are filled, repeat steps 2 through 4 for the remaining inner squares (refer to the example below for further clarification)
            

            // Fill up any unused cells with a space character and return the rows joined together.
            return string.Empty;
        }
        public static string Decode(string s)
        {
            return string.Empty;
        }
    }
}
