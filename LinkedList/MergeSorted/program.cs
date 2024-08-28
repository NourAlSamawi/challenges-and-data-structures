using System;
using NewLinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList list1 = new LinkedList();
        list1.InsertEnd(new Node(1));
        list1.InsertEnd(new Node(3));
        list1.InsertEnd(new Node(5));

        LinkedList list2 = new LinkedList();
        list2.InsertEnd(new Node(2));
        list2.InsertEnd(new Node(4));
        list2.InsertEnd(new Node(6));

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);
        mergedList.PrintList(); // Output: Head -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null
    }
}
