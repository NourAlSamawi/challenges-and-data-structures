using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;
using Xunit;

namespace StackAndQueueTest
{
    
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void TestDeleteMiddleOddSizeStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.DeleteMiddle();
            Assert.Equal("Stack: Top -> 1 -> 2 -> 4 -> 5 (End)", stack.ToString());
        }

        [Fact]
        public void TestDeleteMiddleEvenSizeStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            stack.DeleteMiddle();
            Assert.Equal("Stack: Top -> 1 -> 2 -> 4 -> 5 -> 6 (End)", stack.ToString());
        }

        [Fact]
        public void TestDeleteMiddleEmptyStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();

            stack.DeleteMiddle();
            Assert.Equal("Stack is empty.", stack.ToString());
        }

        [Fact]
        public void TestDeleteMiddleSingleElementStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);

            stack.DeleteMiddle();
            Assert.Equal("Stack is empty.", stack.ToString());
        }
    }

}
