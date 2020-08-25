using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace New_Cashier_Does_Not_Know_About_Space_or_Shift
{
    /*
     * https://www.codewars.com/kata/5d23d89906f92a00267bb83d
     * Some new cashiers started to work at your restaurant.
     * They are good at taking orders, but they don't know how to capitalize words, or use a space bar!
     * All the orders they create look something like this:
     * "milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"
     * 
     * The kitchen staff are threatening to quit, because of how difficult it is to read the orders.
     * Their preference is to get the orders as a nice clean string with spaces and capitals like so:
     * "Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"
     * The kitchen staff expect the items to be in the same order as they appear in the menu.
     * The menu items are fairly simple, there is no overlap in the names of the items:
     */
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
            Console.WriteLine(AnotherGetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"));
        }

        private static string GetOrder(string input)
        {
            var words = new[]
            {
                "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke"
            };

            var order = string.Empty;

            foreach (var word in words)
            {
                var tmp = input.Replace(word, "", StringComparison.InvariantCultureIgnoreCase);
                var count = (input.Length - tmp.Length) / word.Length;
                for (var i = 0; i < count; i++) order += word + " ";
            }

            return order.Trim();
        }

        private static string AnotherGetOrder(string input)
        {
            var words = new[] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };
            var order = string.Empty;

            foreach (var word in words)
            {
                var count = Regex.Matches(input, word.ToLower()).Count;
                for (var i = 0; i < count; i++) order += word + " ";
            }

            return order.Trim();
        }
    }
}