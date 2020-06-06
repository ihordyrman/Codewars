using System;

namespace Binary_Addition
{
    class Program
    {
        //https://www.codewars.com/kata/binary-addition/train/csharp
        //Implement a function that adds two numbers together and returns their sum in binary.
        //The conversion can be done before, or after the addition.

        //The binary number returned should be a string.
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary(51, 12));
            Console.WriteLine(AddBinary(1, 2));
        }
        
        public static string AddBinary(int a, int b)
        {
            return (Convert.ToString(a+b, 2));
        }
    }
}
