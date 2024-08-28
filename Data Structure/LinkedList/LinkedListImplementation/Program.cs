
    using System;

    namespace LinkedListImplementation
    {
        class Program
        {
            static void Main(string[] args)
            {
                LinkedList list = new LinkedList();

                // Adding elements
                list.Add(5);
                list.Add(10);
                list.Add(20);
                list.Add(30);

                // Printing the list
                Console.WriteLine("Original list:");
                list.PrintList();

                // Removing a node
                list.Remove(10);
                Console.WriteLine("\nList after removing 10:");
                list.PrintList();

                // Checking if an element exists
                bool contains = list.Includes(20);
                Console.WriteLine($"\nList contains 20: {contains}");

                // Checking if an element does not exist
                contains = list.Includes(10);
                Console.WriteLine($"List contains 10: {contains}");
            }
        }
    }


