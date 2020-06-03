using System;

namespace Michael.Algos.LinkedList
{
    class Node
    {
        public int Val;
        public Node Next;

        public Node(int val)
        {
            Val = val;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var head = Add(null, new Node(1));
            head = Add(head, new Node(2));
            head = Add(head, new Node(3));

            head = Remove(head, 3);

            Print(head);
        }

        private static Node Add(Node head, Node node)
        {
            if (head == null)
                head = node;
            else
            {
                var cur = head;
                while (cur.Next != null)
                    cur = head.Next;
                cur.Next = node;
            }

            return head;
        }

        private static Node Remove(Node head, int val)
        {
            Node prev = null;
            var cur = head;
            while (cur.Next != null)
            {
                if (cur.Val == val)
                {
                    break;
                }
                prev = cur;
                cur = cur.Next;
            }

            var newHead = head;
            if (cur != null)
            {
                if (cur == head)
                    newHead = head.Next;
                else if (cur.Next != null)
                    prev.Next = cur.Next;
                else
                    prev.Next = null;
            }

            return newHead;
        }

        private static void Print(Node head)
        {
            var cur = head;
            while (cur != null)
            {
                Console.WriteLine(cur.Val);
                cur = cur.Next;
            }
        }
    }
}
