using System;
using System.Diagnostics;

namespace DrinkAbout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PeopleWithAgeDrink(11));
            Console.WriteLine(PeopleWithAgeDrink(14));
            Console.WriteLine(PeopleWithAgeDrink(18));
            Console.WriteLine(PeopleWithAgeDrink(20));
        }

        private static string PeopleWithAgeDrink(int old)
        {
            if (old <= 13) return "drink toddy";
            if (old <= 17) return "drink coke";
            if (old <= 20) return "drink beer";
            return "drink whisky";
        }
    }
}
