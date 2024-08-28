using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class LinkedList
    {
        public Node Head { get; private set; }

        public LinkedList()
        {
            Head = null;
        }

        // Adds a new node to the end of the list
        public void Add(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(data);
            }
        }

        // Checks if a node with the specified data exists
        public bool Includes(int data)
        {
            Node current = Head;
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

        // Removes the first node with the specified data
        public void Remove(int data)
        {
            if (Head == null) return;

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }
        public void RemoveDuplicate()
        {
            Node current = Head;

            while (current != null)
            {
                Node index = current;
                while (index.Next != null)
                {
                    if (current.Data == index.Next.Data)
                    {
                        index.Next = index.Next.Next;
                    }
                    else
                    {
                        index = index.Next;
                    }
                }
                current = current.Next;
            }
        }

        // Prints the contents of the list
        public void PrintList()
        {
            Node current = Head;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Head -> ");
            while (current != null)
            {
                sb.Append($"{current.Data} -> ");
                current = current.Next;
            }
            sb.Append("Null");
            Console.WriteLine(sb.ToString());
        }
    }

}
