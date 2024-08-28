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
    }
}