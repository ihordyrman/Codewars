using System;

namespace Linked_Lists
{
    // https://www.codewars.com/kata/55beec7dd347078289000021/train/csharp

    // Linked Lists - Length & Count
    // Implement Length() to count the number of nodes in a linked list.
    // Node.Length(nullptr) => 0
    // Node.Length(1 -> 2 -> 3 -> nullptr) => 3

    // Implement Count() to count the occurrences of a that satisfy a condition provided by a predicate which takes in a node's Data value.
    // Node.Count(null, value => value == 1) => 0
    // Node.Count(1 -> 3 -> 5 -> 6, value => value % 2 != 0) => 3
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(10);
        }
    }

    public partial class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static int Length(Node head)
        {
            if (head == null) return 0;
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }

        public static int Count(Node head, Predicate<int> func)
        {
            if (head == null) return 0;
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                if (func(temp.Data)) count++;
                temp = temp.Next;
            }

            return count;
        }
    }
}
