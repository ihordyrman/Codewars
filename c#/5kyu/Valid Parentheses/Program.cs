using System;
using System.Linq;

namespace Valid_Parentheses
{
    class Program
    {
        // https://www.codewars.com/kata/52774a314c2333f0a7000688

        // Write a function called that takes a string of parentheses,
        // and determines if the order of the parentheses is valid.
        // The function should return true if the string is valid, and false if it's invalid.

        // Examples
        // "()"              =>  true
        // ")(()))"          =>  false
        // "("               =>  false
        // "(())((()())())"  =>  true
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses("(34)1"));
            Console.WriteLine(ValidParentheses( "t)(a((c(" ));
        }

        private static bool ValidParentheses(string input)
        {
            int left = 0;
            int right = 0;
            foreach (var c in input)
            {
                switch (c)
                {
                    case ')':
                        left++;
                        break;
                    case '(':
                        right++;
                        break;
                }

                if (left > right) return false;
            }

            return left == right && !input.StartsWith(')') && !input.EndsWith('(');
        }
    }
}