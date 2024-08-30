using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    public class MinStack
    {
        private Stack<int> mainStack;
        private Stack<int> minStack;

        public MinStack()
        {
            mainStack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int x)
        {
            mainStack.Push(x);
            if (minStack.Count == 0 || x <= minStack.Peek())
            {
                minStack.Push(x);
            }
        }

        public int Pop()
        {
            if (mainStack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            int popped = mainStack.Pop();
            if (popped == minStack.Peek())
            {
                minStack.Pop();
            }
            return popped;
        }

        public int Top()
        {
            if (mainStack.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            return mainStack.Peek();
        }

        public bool IsEmpty()
        {
            return mainStack.Count == 0;
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            return minStack.Peek();
        }

        public void PrintStack()
        {
            Console.WriteLine("Top -> " + string.Join(" -> ", mainStack));
        }
    }
}
