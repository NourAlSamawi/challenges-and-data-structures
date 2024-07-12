using System;
using NewLinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Test adding nodes
        list.InsertEnd(new Node(5));
        list.InsertEnd(new Node(10));
        list.InsertEnd(new Node(20));
        list.InsertEnd(new Node(30));

        // Print the list
        list.PrintList(); // Output: Head -> 5 -> 10 -> 20 -> 30 -> Null

        // Remove a node
        list.Remove(10);
        list.PrintList(); // Output: Head -> 5 -> 20 -> 30 -> Null

        // Check if the list includes a value
        Console.WriteLine(list.Includes(20)); // Output: True
        Console.WriteLine(list.Includes(10)); // Output: False

        // Remove a node from an empty list
        LinkedList emptyList = new LinkedList();
        emptyList.Remove(10); // Output: The list is empty.

        // Print empty list
        emptyList.PrintList(); // Output: Head -> Null
    }
}
