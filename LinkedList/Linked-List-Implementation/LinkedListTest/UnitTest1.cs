using System.Collections.Generic;
using LinkedListImplementation;
namespace LinkedListTest
{
    public class UnitTest1
    {

        [Fact]
        public void TestRemoveFromEnd()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.Remove(30);

            Assert.False(list.Includes(30));
            // Optionally, use PrintList() method to verify contents if needed
        }

        [Fact]
        public void TestPrintList()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Redirect Console output to capture it
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);

            list.PrintList();

            var output = sw.ToString().Trim();
            Assert.Equal("Head -> 5 -> 10 -> 20 -> Null", output);
        }

        [Fact]
        public void Test_No_Duplicates()
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.RemoveDuplicate();

            Node current = list.Head;
            Assert.Equal(1, current.Data);
            current = current.Next;
            Assert.Equal(2, current.Data);
            current = current.Next;
            Assert.Equal(3, current.Data);
        }

        [Fact]
        public void Test_Remove_Duplicates()
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);

            list.RemoveDuplicate();

            Node current = list.Head;
            Assert.Equal(1, current.Data);
            current = current.Next;
            Assert.Equal(2, current.Data);
            current = current.Next;
            Assert.Equal(3, current.Data);
        }

        [Fact]
        public void Test_All_Duplicates()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(5);
            list.Add(5);

            list.RemoveDuplicate();

            Node current = list.Head;
            Assert.Equal(5, current.Data);
            Assert.Null(current.Next);
        }
    }
}
}