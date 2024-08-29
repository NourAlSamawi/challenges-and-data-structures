namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack Example
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(5);
            Console.WriteLine("Stack after pushes:");
            stack.PrintStack();

            int popped = stack.Pop();
            Console.WriteLine($"Popped: {popped}");
            int peeked = stack.Peek();
            Console.WriteLine($"Peeked: {peeked}");
            Console.WriteLine($"Is stack empty: {stack.IsEmpty()}");

            // Queue Example
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(5);
            Console.WriteLine("Queue after enqueues:");
            queue.PrintQueue();

            int dequeued = queue.Dequeue();
            Console.WriteLine($"Dequeued: {dequeued}");
            int peekedQueue = queue.Peek();
            Console.WriteLine($"Peeked: {peekedQueue}");
            Console.WriteLine($"Is queue empty: {queue.IsEmpty()}");
        }
    }
}
