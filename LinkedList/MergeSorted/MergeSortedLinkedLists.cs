using System;
using Xunit;
using NewLinkedList;

public class MergeSortedLinkedListsTests
{
    [Fact]
    public void Test_MergeSortedLists_WhenOneListIsEmpty()
    {
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();
        list2.InsertEnd(new Node(1));
        list2.InsertEnd(new Node(3));
        list2.InsertEnd(new Node(5));

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);
        Assert.Equal("Head -> 1 -> 3 -> 5 -> Null", GetListString(mergedList));
    }

    [Fact]
    public void Test_MergeSortedLists_WhenBothListsAreEmpty()
    {
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);
        Assert.Equal("Head -> Null", GetListString(mergedList));
    }

    [Fact]
    public void Test_MergeSortedLists_ExampleTwo()
    {
        LinkedList list1 = new LinkedList();
        list1.InsertEnd(new Node(5));
        list1.InsertEnd(new Node(10));
        list1.InsertEnd(new Node(15));

        LinkedList list2 = new LinkedList();
        list2.InsertEnd(new Node(2));
        list2.InsertEnd(new Node(3));
        list2.InsertEnd(new Node(20));

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);
        Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", GetListString(mergedList));
    }

    private string GetListString(LinkedList list)
    {
        Node current = list.head;
        string result = "Head -> ";
        while (current != null)
        {
            result += current.Data + " -> ";
            current = current.Next;
        }
        result += "Null";
        return result;
    }
}
