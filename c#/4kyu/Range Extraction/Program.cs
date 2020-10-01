using System;
using System.Collections.Generic;

namespace Range_Extraction
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Extract(new[] { 1, 2, 3, 4 })); // 1-4
            Console.WriteLine(Extract(new[] { 1, 2 })); // 1,2
            Console.WriteLine(Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })); // "-6,-3-1,3-5,7-11,14,15,17-20"
        }

        public static string Extract(int[] args)
        {
            var result = new List<string>();

            for (int i = 0; i < args.Length; i++)
            {
                if (i + 1 < args.Length && args[i] + 1 == args[i + 1])
                {
                    // if last two characters in list and the same
                    if (i + 2 == args.Length)
                    {
                        result.Add(args[i].ToString());
                        result.Add(args[i + 1].ToString());
                        i++;
                        continue;
                    }

                    // if only two charactes the same
                    if (args[i + 2] != args[i + 1] + 1)
                    {
                        result.Add(args[i].ToString());
                        result.Add(args[i + 1].ToString());
                        i++;
                        continue;
                    }

                    // if range of charactes
                    for (int j = i + 2; j < args.Length; j++)
                    {
                        if (args[j] - 1 != args[j - 1])
                        {
                            result.Add(args[i].ToString() + "-" + args[j - 1].ToString());
                            i = j - 1;
                            break;
                        }
                        else if (j + 1 == args.Length)
                        {
                            result.Add(args[i].ToString() + "-" + args[j].ToString());
                            i = j;
                            break;
                        }
                    }
                }
                else
                {
                    result.Add(args[i].ToString());
                }
            }

            return string.Join(",", result);
        }
    }
}
