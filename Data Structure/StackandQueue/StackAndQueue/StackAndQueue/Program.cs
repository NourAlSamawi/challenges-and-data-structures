namespace StackAndQueue
{
        class Program
        {
            static void Main(string[] args)
            {


                MinStack minStack = new MinStack();

                // Push elements to the stack
                minStack.Push(15);
                minStack.Push(7);
                minStack.Push(12);
                minStack.Push(3);

                // Print the stack
                Console.WriteLine("Current Stack:");
                minStack.PrintStack(); // Expected output: Top -> 3 -> 12 -> 7 -> 15

                // Get the minimum element
                Console.WriteLine("\nMinimum Element: " + minStack.GetMin()); // Expected output: 3

                // Pop the top element
                Console.WriteLine("\nPopped Element: " + minStack.Pop()); // Expected output: 3
                minStack.PrintStack(); // Expected output: Top -> 12 -> 7 -> 15

                // Get the new minimum element
                Console.WriteLine("\nMinimum Element: " + minStack.GetMin()); // Expected output: 7

                // Peek the top element
                Console.WriteLine("\nTop Element: " + minStack.Top()); // Expected output: 12

                // Push another element
                minStack.Push(2);
                Console.WriteLine("\nAfter Pushing 2:");
                minStack.PrintStack(); // Expected output: Top -> 2 -> 12 -> 7 -> 15

                // Get the new minimum element
                Console.WriteLine("\nMinimum Element: " + minStack.GetMin()); // Expected output: 2

                // Check if the stack is empty
                Console.WriteLine("\nIs the stack empty? " + minStack.IsEmpty()); // Expected output: False
           
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
                
            
            
            
                Console.WriteLine("---------------------------------");

                // Create a new instance of StackWithDeleteMiddle
                StackWithDeleteMiddle stack2 = new StackWithDeleteMiddle();

                // Push some elements onto the stack
                stack2.Push(7);
                stack2.Push(14);
                stack2.Push(3);
                stack2.Push(8);
                stack2.Push(5);

                // Display the stack
                Console.WriteLine("Initial Stack:");
                Console.WriteLine(stack2); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7

                // Delete the middle element
                stack2.DeleteMiddle();

                // Display the stack after deleting the middle element
                Console.WriteLine("Stack after deleting the middle element:");
                Console.WriteLine(stack2); // Stack: Top -> 5 -> 8 -> 14 -> 7

                // Push more elements onto the stack
                stack2.Push(2);
                stack2.Push(9);
                stack2.Push(11);

                // Display the stack
                Console.WriteLine("Stack after adding more elements:");
                Console.WriteLine(stack2); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7

                // Delete the middle element again
                stack2.DeleteMiddle();

                // Display the stack after deleting the middle element again
                Console.WriteLine("Stack after deleting the middle element again:");
                Console.WriteLine(stack2); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7
            
}
           }
}
