using System;
using System.Xml.Linq;

namespace NewLinkedList
{
    internal class LinkedList
    {
        public Node head;

        public void InsertToHead(Node current)
        {
            current.Next = head;
            head = current;
        }

        public void InsertEnd(Node current)
        {
            if (head == null)
            {
                InsertToHead(current);
                return;
            }

            Node node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = current;
        }

        public bool Includes(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public void PrintList()
        {
            Node current = head;
            if (head == null)
            {
                Console.WriteLine("Head -> Null");
                return;
            }

            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}
