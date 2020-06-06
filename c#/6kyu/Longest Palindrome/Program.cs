using System;

namespace Longest_Palindrome
{
    // https://www.codewars.com/kata/54bb6f887e5a80180900046b/train/csharp

    // Longest Palindrome
    // Find the length of the longest substring in the given string s that is the same in reverse.
    //
    // As an example, if the input was “I like racecars that go fast”, the substring (racecar) length would be 7.
    //
    // If the length of the input string is 0, the return value must be 0.
    // Example:
    // "a" -> 1 
    // "aab" -> 2  
    // "abcde" -> 1
    // "zzbaabcd" -> 4
    // "" -> 0
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLongestPalindrome("aa")); // 2
            Console.WriteLine(GetLongestPalindrome("baa")); // 2
            Console.WriteLine(GetLongestPalindrome("abc0cba1")); //7
            Console.WriteLine(GetLongestPalindrome("12 21glg")); // 5
            Console.WriteLine(GetLongestPalindrome("   ")); // 3
        }

        private static int GetLongestPalindrome(string str)
        {
            var palindromeCount = 0;
            if (string.IsNullOrEmpty(str)) return palindromeCount;
            if (str.Length == 1) return 1;
            for (var i = 0; i < str.Length; i++)
            {
                var index = str.LastIndexOf(str[i]);
                if (i == index || str[i] != str[index]) continue;
                var innerCount = 0;
                var left = i;
                var right = index;
                
                while (true)
                {
                    if (left == right)
                    {
                        innerCount++;
                        break;
                    }
                        
                    innerCount += 2;
                    left++;
                    right--;
                        
                    if (str[left] != str[right] || left > right) break;
                }

                palindromeCount = innerCount > palindromeCount ? innerCount : palindromeCount;
            }
            return palindromeCount;
        }
    }
}