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
            var newNode = new Node(data);
            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            int data = front.Data;
            front = front.Next;
            if (front == null)
                rear = null;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void PrintQueue()
        {
            var current = front;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

}
