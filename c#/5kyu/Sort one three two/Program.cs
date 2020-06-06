using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_one_three_two
{
    class Program
    {
        // https://www.codewars.com/kata/56f4ff45af5b1f8cd100067d/train/csharp

        // Hey You !
        // Sort these integers for me ...
        // By name ...
        // Do it now !

        // Input
        // Range is 0-999
        // There may be duplicates
        // The array may be empty

        // Example
        // Input: 1, 2, 3, 4
        // Equivalent names: "one", "two", "three", "four"
        // Sorted by name: "four", "one", "three", "two"
        // Output: 4, 1, 3, 2

        // Notes
        // Don't fret about formatting rules. If rules are consistently applied it has no effect anyway:
        // e.g. one hundred one, one hundred two is same order as one hundred and one, one hundred and two
        // e.g. ninety eight, ninety nine is same order as ninety-eight, ninety-nine
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // var x = Sort(new[] {51, 32, 73, 14});
            // var c = Sort(new[] {1, 2, 3, 4}); // 4, 1, 3, 2
            var a = Sort(new[] {rnd.Next(0, 999), rnd.Next(0, 999), rnd.Next(0, 999)});
            // var b = Sort(new[] {844, 846, 804});
        }

        private static IEnumerable<int> Sort(int[] array)
        {
            var strings = new string[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] < 20) strings[i] = ((Strings) array[i]).ToString();
                else if (array[i] > 19 && array[i] < 100)
                {
                    if (array[i] % 10 == 0) strings[i] = ((Strings) array[i]).ToString();
                    else
                    {
                        var firstValue = array[i].ToString()[0] + 0.ToString();
                        var secondValue = array[i] % 10;
                        strings[i] = Enum.Parse(typeof(Strings), firstValue) + "-" + (Strings) secondValue;
                    }
                }
                else
                {
                    var value = Enum.Parse(typeof(Strings), array[i].ToString()[0].ToString());
                    value += " hundred";
                    var secondInt = array[i] % 100;
                    var firstValue = secondInt.ToString()[0] + 0.ToString();
                    var secondValue = secondInt % 10;
                    value += " " + Enum.Parse(typeof(Strings), firstValue) + "-" + (Strings) secondValue;
                    strings[i] = value.ToString().Trim();
                }
            }

            strings = strings.OrderBy(x => x).ToArray();

            for (var i = 0; i < strings.Length; i++)
            {
                var values = strings[i].Split(' ');
                if (values.Length == 1)
                    array[i] = (int) Enum.Parse(typeof(Strings), strings[i]);
                else
                {
                    var value = "";
                    foreach (var s in values)
                    {
                        value += (int) Enum.Parse(typeof(Strings), s);
                    }

                    array[i] = int.Parse(value);
                }
            }

            return array;
        }

        enum Strings
        {
            zero,
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            eleven,
            twelve,
            thirteen,
            fourteen,
            fifteen,
            sixteen,
            seventeen,
            eighteen,
            nineteen,
            twenty = 20,
            thirty = 30,
            fourty = 40,
            fifty = 50,
            sixty = 60,
            seventy = 70,
            eighty = 80,
            ninety = 90,
        }
    }
}