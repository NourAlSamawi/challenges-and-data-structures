namespace StackAndQueue
{
        class Program
        {
            static void Main(string[] args)
            {
                // Stack Example
                Console.WriteLine("Stack Example:");
                Stack stack = new Stack();

                // Push nodes onto the stack
                stack.Push(10);
                stack.Push(5);
                stack.Push(20);
                stack.PrintStack(); // Expected Output: 20 -> 5 -> 10

                // Peek the top node
                Console.WriteLine($"Peek: {stack.Peek()}"); // Expected Output: 20

                // Pop a node from the stack
                Console.WriteLine($"Popped: {stack.Pop()}"); // Expected Output: 20
                stack.PrintStack(); // Expected Output: 5 -> 10

                // Check if the stack is empty
                Console.WriteLine($"Is Empty: {stack.IsEmpty()}"); // Expected Output: False

                // Queue Example
                Console.WriteLine("\nQueue Example:");
                Queue queue = new Queue();

                // Enqueue nodes into the queue
                queue.Enqueue(10);
                queue.Enqueue(20);
                queue.Enqueue(30);
                queue.PrintQueue(); // Expected Output: 10 -> 20 -> 30

                // Peek the front node
                Console.WriteLine($"Peek: {queue.Peek()}"); // Expected Output: 10

                // Dequeue a node from the queue
                Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Expected Output: 10
                queue.PrintQueue(); // Expected Output: 20 -> 30

                // Check if the queue is empty
                Console.WriteLine($"Is Empty: {queue.IsEmpty()}"); // Expected Output: False


                // Stack with reverse example
                Console.WriteLine("Stack with Reverse Example:");
                StackWithReverse stack1 = new StackWithReverse();

                // Push nodes onto the stack
                stack1.Push(1);
                stack1.Push(2);
                stack1.Push(3);
                stack1.Push(4);
                stack1.Push(5);

                Console.WriteLine(stack); // Expected Output: Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1

                // Reverse the stack
                stack1.ReverseStack();
                Console.WriteLine(stack); // Expected Output: Stack: Top -> 1 -> 2 -> 3 -> 4 -> 5

                // Push more elements and reverse again
                stack1.Push(6);
                stack1.Push(7);
                Console.WriteLine(stack); // Expected Output: Stack: Top -> 7 -> 6 -> 1 -> 2 -> 3 -> 4 -> 5
                stack1.ReverseStack();
                Console.WriteLine(stack); // Expected Output: Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1 -> 6 -> 7
            }
           }
}
