using System;

namespace The_Deaf_Rats_of_Hamelin
{
    static class Program
    {
        // https://www.codewars.com/kata/598106cb34e205e074000031/train/csharp
        
        // Story
        // The Pied Piper has been enlisted to play his magical tune and coax all the rats out of town.
        // But some of the rats are deaf and are going the wrong way!
        
        // Kata Task
        // How many deaf rats are there?
        
        // Legend
        // P = The Pied Piper
        // O~ = Rat going left
        // ~O = Rat going right
        
        // Example
        // ex1 ~O~O~O~O P has 0 deaf rats
        // ex2 P O~ O~ ~O O~ has 1 deaf rat
        // ex3 ~O~O~O~OP~O~OO~ has 2 deaf rats
        static void Main(string[] args)
        {
            Console.WriteLine(CountDeafRats("~0~0~0~0 P")); // 0
            Console.WriteLine(CountDeafRats("P O~ O~ ~O O~")); // 1
            Console.WriteLine(CountDeafRats("~O~O~O~OP~O~OO~")); // 2
            Console.WriteLine(CountDeafRats("O~~OO~~OO~~OO~ P~OO~~OO~~OO~~O")); // 8
        }

        private static int CountDeafRats(string town)
        {
            var piperPosition = town.IndexOf('P');
            var deafRatsCount = 0;
            for (var i = 0; i < town.Length - 1; i++)
            {
                if (town[i] == ' ' || town [i] == 'P') continue;
                var rat = string.Concat(town[i], town[i+1]);
                switch (rat)
                {
                    case "~O" when i > piperPosition:
                    case "O~" when i < piperPosition:
                        deafRatsCount++;
                        break;
                }
                i++;
            }
            return deafRatsCount;
        }
    }
}
