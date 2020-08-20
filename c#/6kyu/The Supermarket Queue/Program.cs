using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Supermarket_Queue
{
    /*
     * There is a queue for the self-checkout tills at the supermarket.
     * Your task is write a function to calculate the total time required for all the customers to check out!
     *
     * input:
     * customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
     * n: a positive integer, the number of checkout tills.
     *
     * output:
     * The function should return an integer, the total time required.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QueueTime(new[] {1, 2, 3, 4}, 1)); // 10
            Console.WriteLine(QueueTime(new int[] { }, 1)); // 0
            Console.WriteLine(QueueTime(new[] {2, 2, 3, 3, 4, 4}, 2)); // 9
            Console.WriteLine(BetterQueueTime(new[] {1, 2, 3, 4, 5}, 100)); // 5
        }

        private static long QueueTime(int[] customers, int n)
        {
            if (n <= 1) return customers.Sum();
            var arr = new int[n];

            var current = 0;
            foreach (var x in customers)
            {
                arr[current] += x;
                for (var j = 0; j < arr.Length; j++)
                    if (arr[j] < arr[current])
                        current = j;
            }

            return arr.Max();
        }

        private static long BetterQueueTime(int[] customers, int n)
        {
            var arr = new List<int>(Enumerable.Repeat(0, n));
            foreach (var customer in customers)
                arr[arr.IndexOf(arr.Min())] += customer;
            return arr.Max();
        }
    }
}