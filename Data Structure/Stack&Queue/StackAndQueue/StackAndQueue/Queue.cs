using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        private Node front;
        private Node rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear != null)
            {
                rear.Next = newNode;
            }
            rear = newNode;
            if (front == null)
            {
                front = rear;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            int data = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void PrintQueue()
        {
            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
