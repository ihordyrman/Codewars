using System;

namespace BasicVariable
{
    internal static class Program
    {
        private static readonly string Name;
        private const string A = "code";
        private const string B = "wa.rs";

        static Program()
        {
            Name = A + B;
        }

        private static void Main()
        {
            Console.WriteLine(Name);
        }
    }
}
