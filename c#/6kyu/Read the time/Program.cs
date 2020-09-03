using System;
using System.Collections.Generic;

namespace Read_the_time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quarter past eleven" == Solve("11:15"));
            Console.WriteLine("one o'clock" == Solve("13:00"));
            Console.WriteLine("nine minutes past one" == Solve("13:09"));
            Console.WriteLine("quarter past one" == Solve("13:15"));
            Console.WriteLine("twenty nine minutes past one" == Solve("13:29"));
            Console.WriteLine("half past one" == Solve("13:30"));
            Console.WriteLine("twenty nine minutes to two" == Solve("13:31"));
            Console.WriteLine("quarter to two" == Solve("13:45"));
            Console.WriteLine("one minute to two" == Solve("13:59"));
            Console.WriteLine("twelve minutes to one" == Solve("00:48"));
            Console.WriteLine("eight minutes past midnight" == Solve("00:08"));
            Console.WriteLine("twelve o'clock" == Solve("12:00"));
            Console.WriteLine("midnight" == Solve("00:00"));
            Console.WriteLine("one minute past seven" == Solve("19:01"));
            Console.WriteLine("one minute past seven" == Solve("07:01"));
            Console.WriteLine("one minute to two" == Solve("01:59"));
            Console.WriteLine("one minute past twelve" == Solve("12:01"));
            Console.WriteLine("one minute past midnight" == Solve("00:01"));
            Console.WriteLine("twenty nine minutes to twelve" == Solve("11:31"));
            Console.WriteLine("twenty nine minutes to midnight" == Solve("23:31"));
            Console.WriteLine("one minute past midnight" == Solve("00:01"));
            Console.WriteLine("quarter to twelve" == Solve("11:45"));
            Console.WriteLine("one minute to twelve" == Solve("11:59"));
            Console.WriteLine("quarter to midnight" == Solve("23:45"));
            Console.WriteLine("one minute to midnight" == Solve("23:59"));
            Console.WriteLine("quarter to two" == Solve("01:45"));
        }

        private static string Solve(string time)
        {
            var hoursDictionary = new Dictionary<int, string>
            {
                {1, "one"}, {13, "one"},
                {2, "two"}, {14, "two"},
                {3, "three"}, {15, "three"},
                {4, "four"}, {16, "four"},
                {5, "five"}, {17, "five"},
                {6, "six"}, {18, "six"},
                {7, "seven"}, {19, "seven"},
                {8, "eight"}, {20, "eight"},
                {9, "nine"}, {21, "nine"},
                {10, "ten"}, {22, "ten"},
                {11, "eleven"}, {23, "eleven"},
                {12, "twelve"}, {0, "midnight"},
                {24, "midnight"}
            };

            var minutesDictionary = new Dictionary<int, string>
            {
                {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"},
                {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"},
                {9, "nine"}, {10, "ten"}, {11, "eleven"}, {12, "twelve"},
                {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"},
                {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}, {20, "twenty"},
                {30, "thirty"}
            };

            var hourMinutes = time.Split(":");
            var hours = int.Parse(hourMinutes[0]);
            var minutes = int.Parse(hourMinutes[1]);
            var prefix = " to ";

            if (hours == 0 && minutes == 0) return "midnight";
            if (minutes == 0) return hoursDictionary[hours] + " o'clock";
            if (minutes == 30) return "half past " + hoursDictionary[hours];
            if (minutes == 15) return "quarter past " + hoursDictionary[hours];
            if (minutes == 45) return "quarter to " + hoursDictionary[hours + 1];
            if (minutes > 30)
            {
                hours++;
                if (hours == 24) hours = 0;
                minutes = 60 - (minutes / 10 * 10 + minutes % 10);
            }
            else
            {
                minutes = minutes / 10 * 10 + minutes % 10;
                prefix = " past ";
            }

            string strMinutes;
            if (minutes > 10 && minutes < 20)
                strMinutes = minutesDictionary[minutes];
            else
            {
                var stringX = minutes / 10 != 0 ? minutesDictionary[minutes / 10 * 10] : string.Empty;
                var stringY = minutes % 10 != 0 ? minutesDictionary[minutes % 10] : string.Empty;
                strMinutes = (stringX + " " + stringY).Trim();
            }

            return strMinutes == "one"
                ? "one minute" + prefix + hoursDictionary[hours]
                : strMinutes + " minutes" + prefix + hoursDictionary[hours];
        }

        public static string BetterSolve(string time)
        {
            string[] hoursArr =
            {
                "midnight", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten", "eleven", "midnight",
            };
            string[] minutesArr =
            {
                "zero", "one", "two", "three", "four", "five", "six",
                "seven", "eight", "nine", "ten", "eleven", "twelve",
                "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                "eighteen", "nineteen", "twenty", "twenty one", "twenty two",
                "twenty three", "twenty four", "twenty five", "twenty six",
                "twenty seven", "twenty eight", "twenty nine",
            };

            var hourMinutes = time.Split(':');
            var minutes = int.Parse(hourMinutes[1]);
            var hour = int.Parse(hourMinutes[0]);
            switch (minutes)
            {
                case 0:
                    return hour == 0 ? "midnight" : hoursArr[hour] + " o'clock";
                case 1:
                    return "one minute past " + hoursArr[hour];
                case 59:
                    return "one minute to " + hoursArr[hour + 1];
                case 15:
                    return "quarter past " + hoursArr[hour];
                case 30:
                    return "half past " + hoursArr[hour];
                case 45:
                    return "quarter to " + hoursArr[hour + 1];
                default:
                {
                    if (minutes <= 30)
                        return minutesArr[minutes] + " minutes past " + hoursArr[hour];
                    return minutesArr[60 - minutes] + " minutes to " + hoursArr[hour + 1];
                }
            }
        }
    }
}