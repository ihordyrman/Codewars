﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Best_travel
{
    class Program
    {
        /*
         * https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa

         * John and Mary want to travel between a few towns A, B, C ...
         * Mary has on a sheet of paper a list of distances between these towns.
         * ls = [50, 55, 57, 58, 60]. John is tired of driving and he says to Mary
         * that he doesn't want to drive more than t = 174 miles and he will visit only 3 towns.
         * Which distances, hence which towns, they will choose so that the sum of the distances
         * is the biggest possible to please Mary and John?

         * Example:
         * With list ls and 3 towns to visit they can make a choice between:
         * [50,55,57],[50,55,58],[50,55,60],[50,57,58],[50,57,60],
         * [50,58,60],[55,57,58],[55,57,60],[55,58,60],[57,58,60].
         * The sums of distances are then: 162, 163, 165, 165, 167, 168, 170, 172, 173, 175.
         * The biggest possible sum taking a limit of 174 into account is then 173
         * and the distances of the 3 corresponding towns is [55, 58, 60].
         * The function chooseBestSum (or choose_best_sum or ... depending on the language)
         * will take as parameters t (maximum sum of distances, integer >= 0),
         * k (number of towns to visit, k >= 1) and ls (list of distances,
         * all distances are positive or null integers and this list has at least one element).
         * The function returns the "best" sum ie the biggest possible sum of k
         * distances less than or equal to the given limit t, if that sum exists, or otherwise nil,
         * null, None, Nothing, depending on the language. With C++, C, Rust, Swift, Go, Kotlin return -1.

         * Examples:
         * ts = [50, 55, 56, 57, 58] choose_best_sum(163, 3, ts) -> 163
         * xs = [50] choose_best_sum(163, 3, xs) -> nil (or null or ... or -1 (C++, C, Rust, Swift, Go)
         * ys = [91, 74, 73, 85, 73, 81, 87] choose_best_sum(230, 3, ys) -> 228
         */
        static void Main(string[] args)
        {
            Console.WriteLine(ChooseBestSum(5, 3, new List<int> {1, 2, 3, 4, 5, 6}));
            Console.WriteLine(ChooseBestSum(163, 3, new List<int> {50, 55, 56, 57, 58})); // 163
            Console.WriteLine(ChooseBestSum(163, 3, new List<int> {50})); // null
            Console.WriteLine(ChooseBestSum(230, 3, new List<int> {91, 74, 73, 85, 73, 81, 87})); // 228
        }

        private static int? ChooseBestSum(int t, int k, List<int> ls)
        {
            int max = 0;
            for (var i = 0; i < ls.Count; i++)
            {
                for (var j = 0; j < ls.Count; j++)
                {
                    if (i == j) continue;
                    if (j + (k - 1) > ls.Count) continue;

                    //TODO: find sum of k numbers
                    var temp = ls[i];
                    for (int l = i + 1; l <= k - 1; l++)
                    {
                        temp += ls[l];
                    }

                    if (temp > max && temp <= t) max = temp;
                }
            }

            return max > 0 ? max : (int?) null;
        }
    }
}