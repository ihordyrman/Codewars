using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_unique_number
{
    /*
     * There is an array with some numbers. All numbers are equal except for one. Try to find it!
     *
     * findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
     * findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
     *
     * It’s guaranteed that array contains at least 3 numbers.
     * The tests contain some very huge arrays, so think about performance.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUnique(new[] {1, 2, 2, 2}));
            Console.WriteLine(GetUnique(new [] {-2, 2, 2, 2}));
            Console.WriteLine(BetterGetUnique(new [] {11, 11, 14, 11, 11}));
        }

        private static int GetUnique(IEnumerable<int> numbers)
        {
            var dic = new Dictionary<int, int>();

            foreach (var number in numbers)
                if (dic.ContainsKey(number))
                    dic[number]++;
                else
                    dic.Add(number, 1);

            return dic.OrderBy(x => x.Value).First().Key;
        }

        private static int BetterGetUnique(IEnumerable<int> numbers) =>
            numbers.GroupBy(x=>x).Single(x=> x.Count() == 1).Key;
    }
}