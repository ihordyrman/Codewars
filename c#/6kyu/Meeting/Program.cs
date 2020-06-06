using System;
using System.Linq;

namespace Meeting
{
    class Program
    {
        // https://www.codewars.com/kata/59df2f8f08c6cec835000012/train/csharp

        // John has invited some friends. His list is:
        // s = "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";

        // Could you make a program that
        // makes this string uppercase
        // gives it sorted in alphabetical order by last name.

        // When the last names are the same, sort them by first name.
        // Last name and first name of a guest come in the result between parentheses separated by a comma.

        // So the result of function meeting(s) will be:
        // "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)"
        // It can happen that in two distinct families with the same family name two people have the same first name too.
        // Notes: You can see another examples in the "Sample tests".
        static void Main(string[] args)
        {
            Console.WriteLine(
                "(ARNO, ANN)(BELL, JOHN)(CORNWELL, ALEX)(DORNY, ABBA)(KERN, LEWIS)(KORN, ALEX)(META, GRACE)(SCHWARZ, VICTORIA)(STAN, MADISON)(STAN, MEGAN)(WAHL, ALEXIS)");
            Console.WriteLine(Meeting(
                "Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn"));
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "(BELL, MEGAN)(CORNWELL, AMBER)(DORNY, JAMES)(DORRIES, PAUL)(GATES, JOHN)(KERN, ANN)(KORN, ANNA)(META, ALEX)(RUSSEL, ELIZABETH)(STEVE, LEWIS)(WAHL, MICHAEL)");
            Console.WriteLine(Meeting(
                "John:Gates;Michael:Wahl;Megan:Bell;Paul:Dorries;James:Dorny;Lewis:Steve;Alex:Meta;Elizabeth:Russel;Anna:Korn;Ann:Kern;Amber:Cornwell"));
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "(ARNO, ALEX)(ARNO, HALEY)(BELL, SARAH)(CORNWELL, ALISSA)(DORNY, PAUL)(DORRIES, ANDREW)(KERN, ANN)(KERN, MADISON)");
            Console.WriteLine(Meeting(
                "Alex:Arno;Alissa:Cornwell;Sarah:Bell;Andrew:Dorries;Ann:Kern;Haley:Arno;Paul:Dorny;Madison:Kern"));
        }

        private static string Meeting(string s)
        {
            return s.Split(";")
                .Select(x => x.ToUpper())
                .Select(x => x.Split(":"))
                .Select(z => new {firstName = z[0], secondName = z[1]})
                .OrderBy(x => x.secondName)
                .ThenBy(x => x.firstName)
                .Aggregate("", (current, t) => current + $"({t.secondName}, {t.firstName})");
        }
    }
}