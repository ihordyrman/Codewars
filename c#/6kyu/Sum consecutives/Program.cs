using System;
using System.Collections.Generic;

namespace Sum_consecutives
{
    /*
    * Sum consecutives
    * You are given a list/array which contains only integers (positive and negative). 
    * Your job is to sum only the numbers that are the same and consecutive.
    * The result should be one list.
    * 
    * Extra credit if you solve it in one line. 
    * You can assume there is never an empty list/array and there will always be an integer.
    */
    class Program
    {
        static void Main(string[] args)
        {
            PrintList(SumConsecutives(new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 }));
            PrintList(SumConsecutives(new List<int> { -5, -5, 7, 7, 12, 0 }));
        }

        private static void PrintList(List<int> list) 
        {
            foreach (var item in list)
                Console.Write(item + " ");

            Console.WriteLine();
        }

        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> result = new List<int>();
            int currentValue = s[0], currentSum = s[0];
            for (int i = 1; i < s.Count; i++)
            {
                if (currentValue == s[i]) currentSum += currentValue;
                else
                {
                    result.Add(currentSum);
                    currentValue = currentSum = s[i];
                }
            }

            result.Add(currentSum);
            return result;
        }
    }
}
