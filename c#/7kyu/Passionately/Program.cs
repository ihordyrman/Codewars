using System;

namespace Passionately
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(HowMuchILoveYou(7));
            Console.WriteLine(HowMuchILoveYou(3));
            Console.WriteLine(HowMuchILoveYou(6));
        }

        private static string HowMuchILoveYou(int nb_petals)
        {
            if (nb_petals >= 6) nb_petals %= 6;
            return nb_petals switch
            {
                1 => "I love you",
                2 => "a little",
                3 => "a lot",
                4 => "passionately",
                5 => "madly",
                _ => "not at all"
            };
        }
    }
}
