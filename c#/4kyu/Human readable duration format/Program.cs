using System;

namespace Human_readable_duration_format
{
    static class Program
    {
        // https://www.codewars.com/kata/52742f58faf5485cae000b9a

        // Your task in order to complete this Kata is to write a function which formats a duration,
        // given as a number of seconds, in a human-friendly way.

        // The function must accept a non-negative integer.
        // If it is zero, it just returns "now". Otherwise,
        // the duration is expressed as a combination of years, days, hours, minutes and seconds.

        // It is much easier to understand with an example:
        // formatDuration (62)    // returns "1 minute and 2 seconds"
        // formatDuration (3662)  // returns "1 hour, 1 minute and 2 seconds"
        // For the purpose of this Kata, a year is 365 days and a day is 24 hours.

        // Note that spaces are important.

        // Detailed rules
        // The resulting expression is made of components like 4 seconds,
        // 1 year, etc. In general, a positive integer and one of the valid units of time,
        // separated by a space. The unit of time is used in plural if the integer is greater than 1.

        // The components are separated by a comma and a space (", ").
        // Except the last component, which is separated by " and ",
        // just like it would be written in English.

        // A more significant units of time will occur before than a least significant one.
        // Therefore, 1 second and 1 year is not correct, but 1 year and 1 second is.

        // Different components have different unit of times.
        // So there is not repeated units like in 5 seconds and 1 second.

        // A component will not appear at all if its value happens to be zero.
        // Hence, 1 minute and 0 seconds is not valid, but it should be just 1 minute.

        // A unit of time must be used "as much as possible".
        // It means that the function should not return 61 seconds, but 1 minute and 1 second instead.
        // Formally, the duration specified by of a component must not be greater
        // than any valid more significant unit of time.
        static void Main(string[] args)
        {
            Console.WriteLine(FormatDuration(205851834));
            Console.WriteLine(FormatDuration(120));
            Console.WriteLine(FormatDuration(132030240));
            Console.WriteLine(FormatDuration(33243586));
        }
        private static string FormatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            var result = "";
            if (seconds > 31535999)
            {
                result += $"{seconds / 31536000}";
                result += seconds / 31536000 == 1 ? " year" : " years";
                seconds %= 31536000;
            }
            if (seconds > 86399)
            {
                result += $", {seconds / 86400}";
                result += seconds / 86400 > 1 ? " days" : " day";
                seconds %= 86400;
            }
            if (seconds > 3599)
            {
                result += $", {seconds / 3600}";
                result += seconds / 3600 > 1 ? " hours" : " hour";
                seconds %= 3600;
            }
            if (seconds > 59)
            {
                result += $", {seconds / 60}";
                result += seconds / 60 > 1 ? " minutes" : " minute";
                seconds %= 60;
            }
            if (seconds != 0)
            {
                result += $", {seconds}";
                result += seconds > 1 ? " seconds" : " second";
            }
            
            var lastComma = result.LastIndexOf(',');
            if (lastComma != -1) result = result.Remove(lastComma, 1).Insert(lastComma, " and");

            if (result.EndsWith(" and "))
                return result.Remove(result.Length - 4).Trim();

            if (result.StartsWith(" and "))
                return result.Remove(0, 4).Trim();

            if (result.StartsWith(", "))
                return result.Remove(0, 2).Trim();

            return result.Trim();
        }
    }
}