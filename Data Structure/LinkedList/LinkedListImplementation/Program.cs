
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

            // Create a new LinkedList
            LinkedList list1 = new LinkedList();

            // Add nodes to the linked list
            list1.Add(5);
            list1.Add(20);
            list1.Add(20);
            list1.Add(10);
            list1.Add(5);
            list1.Add(10);

            // Print the list before removing duplicates
            Console.WriteLine("Original Linked List:");
            list1.PrintList();  // Expected Output: Head -> 5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null

            // Remove duplicates from the linked list
            list1.RemoveDuplicate();

            // Print the list after removing duplicates
            Console.WriteLine("Linked List After Removing Duplicates:");
            list1.PrintList();  // Expected Output: Head -> 5 -> 20 -> 10 -> Null


        }

        }
    }


