using System;
using System.Collections.Generic;

namespace Can_you_get_the_loop
{
    class Program
    {
        // https://www.codewars.com/kata/52a89c2ea8ddc5547a000863

        // You are given a node that is the beginning of a linked list.
        // This list always contains a tail and a loop.

        // Your objective is to determine the length of the loop.
        // https://i.imgur.com/Rc6RPT5.png
        // For example in the following picture the tail's size is 3 and the loop size is 11.
        // Use the `next' method to get the following node.
        // Note: do NOT mutate the nodes!
        static void Main(string[] args)
        {
            var n1 = new LoopDetector.Node();
            var n2 = new LoopDetector.Node();
            var n3 = new LoopDetector.Node();
            var n4 = new LoopDetector.Node();
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n2;

            Console.WriteLine(GetLoopSize(n1)); // 3
        }

        private static int GetLoopSize(LoopDetector.Node startNode)
        {
            var nodes = new Dictionary<LoopDetector.Node, int>();
            var current = startNode;
            var index = 0;
            if (current == null) return 0;

            while (true)
            {
                if (nodes.ContainsKey(current))
                    return index - nodes[current];

                nodes[current] = index;
                index++;
                current = current.next;
            }
        }
    }

    public class LoopDetector
    {
        public class Node
        {
            public Node next { set; get; }
        }
    }
}