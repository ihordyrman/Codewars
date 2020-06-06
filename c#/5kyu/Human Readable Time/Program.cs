using System;

namespace Human_Readable_Time
{
    class Program
    {
        // https://www.codewars.com/kata/52685f7382004e774f0001f7

        // Write a function, which takes a non-negative integer (seconds)
        // as input and returns the time in a human-readable format (HH:MM:SS)
        // HH = hours, padded to 2 digits, range: 00 - 99
        // MM = minutes, padded to 2 digits, range: 00 - 59
        // SS = seconds, padded to 2 digits, range: 00 - 59

        // The maximum time never exceeds 359999 (99:59:59)
        static void Main(string[] args)
        {
            Console.WriteLine(GetReadableTime(45296));
            Console.WriteLine(GetReadableTime(0));
            Console.WriteLine(GetReadableTime(5));
            Console.WriteLine(GetReadableTime(60));
            Console.WriteLine(GetReadableTime(3475));
            Console.WriteLine(GetReadableTime(86399));
            Console.WriteLine(GetReadableTime(359999));
        }

        private static string GetReadableTime(int seconds) =>
            $"{seconds / 60 / 60:00}:{seconds / 60 % 60:00}:{seconds % 60 % 60 % 60:00}";
    }
}