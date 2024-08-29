using System;
using System.Collections.Generic;
namespace StackAndQueue
{
    public class StackWithDeleteMiddle : Stack<int>
    {
        // Method to delete the middle element
        public void DeleteMiddle()
        {
            int size = GetSize(); // Custom method to get the size of the stack
            if (size == 0)
            {
                Console.WriteLine("Stack is empty. Nothing to delete.");
                return;
            }

            int middleIndex = (size - 1) / 2;
            Stack<int> tempStack = new Stack<int>();

            // Remove elements from the original stack and push them into a temporary stack
            for (int i = 0; i < size; i++)
            {
                int data = Pop();
                if (i != middleIndex)
                {
                    tempStack.Push(data);
                }
            }

            // Push elements back into the original stack
            while (tempStack.Count > 0)
            {
                Push(tempStack.Pop());
            }
        }

        // Custom method to get the size of the stack
        private int GetSize()
        {
            Stack<int> tempStack = new Stack<int>();
            int size = 0;

            // Calculate the size of the stack
            while (this.Count > 0)
            {
                tempStack.Push(this.Pop());
                size++;
            }

            // Restore the original stack
            while (tempStack.Count > 0)
            {
                this.Push(tempStack.Pop());
            }

            return size;
        }

        // Override ToString for custom stack display
        public override string ToString()
        {
            if (this.Count == 0)
                return "Stack is empty.";

            var tempStack = new Stack<int>();
            var result = "Stack: Top -> ";

            while (this.Count > 0)
            {
                int data = this.Pop();
                tempStack.Push(data);
            }

            while (tempStack.Count > 0)
            {
                int data = tempStack.Pop();
                result += data + " -> ";
                this.Push(data); // Restore to original stack
            }

            return result.TrimEnd(' ', '-') + " (End)";
        }
    }
}