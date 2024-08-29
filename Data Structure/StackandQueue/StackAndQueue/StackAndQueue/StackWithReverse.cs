using System;
using System.Collections.Generic;
namespace StackAndQueue
{
    public class StackWithReverse : Stack
    {
        private Queue<int> queue;

        public StackWithReverse() : base()
        {
            queue = new Queue<int>();
        }

        public void ReverseStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Nothing to reverse.");
                return;
            }

            // Transfer elements from stack to queue
            while (!IsEmpty())
            {
                int data = Pop();
                queue.Enqueue(data);
            }

            // Transfer elements from queue back to stack
            while (queue.Count > 0)
            {
                int data = queue.Dequeue();
                Push(data);
            }
        }

        public override string ToString()
        {
            if (IsEmpty())
                return "Stack is empty.";

            var tempStack = new Stack<int>();
            var result = "Stack: Top -> ";

            // Copy current stack to a temporary stack
            while (!IsEmpty())
            {
                int data = Pop();
                tempStack.Push(data);
            }

            // Build result string and restore original stack
            while (tempStack.Count > 0)
            {
                int data = tempStack.Pop();
                result += data + " -> ";
                Push(data); // Restore to original stack
            }

            return result.TrimEnd(' ', '-') + " (End)";
        }
    }
}
