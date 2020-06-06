using System;
using System.Linq;

namespace Exes_and_Ohs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XO("xo"));
            Console.WriteLine(XO("xxOo"));
            Console.WriteLine(XO("xxxm"));
            Console.WriteLine(XO("Oo"));
            Console.WriteLine(XO("ooom"));
        }
        public static bool XO(string input)
        {
            var result = input.ToLowerInvariant().GroupBy(x => x)
                .Where(g => g.Contains('o') || g.Contains('x'))
                .Select(y => new {Counter = y.Count()})
                .ToList();

            switch (result.Count)
            {
                case 1:
                    return false;
                case 2 when result[0].Counter == result[1].Counter:
                    return true;
                default:
                    return true;
            }
        }
    }
}
