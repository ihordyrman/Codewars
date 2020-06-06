using System;
using System.Linq;

namespace Prize_Draw
{
    class Program
    {
        // To participate in a prize draw each one gives his/her firstname.

        // Each letter of a firstname has a value which is its rank in the English alphabet.
        // A and a have rank 1, B and b rank 2 and so on.

        // The length of the firstname is added to the sum of these ranks hence a number som.

        // An array of random weights is linked to the firstnames and each
        // som is multiplied by its corresponding weight to get what they call a winning number.
        static void Main(string[] args)
        {
            Console.WriteLine(NthRank("COLIN,AMANDBA,AMANDAB,CAROL,PauL,JOSEPH", new[] {1, 4, 4, 5, 2, 1}, 4));
        }

        private static string NthRank(string st, int[] we, int n)
        {
            if (string.IsNullOrEmpty(st)) return "No participants";
            var names = st.Split(',');
            if (names.Length < n) return "Not enough participants";

            var winnersList = names
                .Select((name, index) =>
                {
                    var lower = name.ToLower();
                    return new
                    {
                        Name = name,
                        WinningNumber = (lower.Length + lower.Sum(x => x - 'a' + 1)) * we[index]
                    };
                })
                .OrderByDescending(x => x.WinningNumber)
                .ThenBy(x => x.Name)
                .ToArray();

            return winnersList[n - 1].Name;
        }
    }
}