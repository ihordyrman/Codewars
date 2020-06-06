using System;

namespace CreatePhoneNumber
{
    class Program
    {
        // https://www.codewars.com/kata/525f50e3b73515a6db000b83/

        // Write a function that accepts an array of 10 integers (between 0 and 9),
        // that returns a string of those numbers in the form of a phone number.
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Console.WriteLine(CreatePhoneNumber(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }

        private static string CreatePhoneNumber(int[] numbers)
        {
            var result = "";
            for (var i = 0; i < numbers.Length; i++)
            {
                result += i switch
                {
                    0 => $"({numbers[i]}",
                    2 => $"{numbers[i]}) ",
                    5 => $"{numbers[i]}-",
                    _ => numbers[i]
                };
            }
            return result;
        }
    }
}
