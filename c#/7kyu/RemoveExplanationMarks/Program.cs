using System;

namespace RemoveExplanationMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveExclamationMarks("Hel!lo Wor!ld!"));
        }

        private static string RemoveExclamationMarks(string s) => s.Replace("!", "");
    }
}
