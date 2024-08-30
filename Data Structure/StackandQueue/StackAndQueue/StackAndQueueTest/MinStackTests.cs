using System;
using Xunit;
using StackAndQueue;

namespace StackAndQueueTest
{
    public class MinStackTests
    {
        [Fact]
        public void Test_GetMin()
        {
            MinStack stack = new MinStack();
            stack.Push(5);
            stack.Push(3);
            stack.Push(7);
            Assert.Equal(3, stack.GetMin());

            stack.Push(2);
            Assert.Equal(2, stack.GetMin());
        }

        [Fact]
        public void Test_Pop_And_GetMin()
        {
            MinStack stack = new MinStack();
            stack.Push(5);
            stack.Push(3);
            stack.Push(7);
            stack.Push(2);

            stack.Pop();
            Assert.Equal(3, stack.GetMin());

            stack.Pop();
            Assert.Equal(3, stack.GetMin());
        }

        [Fact]
        public void Test_Push_And_GetMin()
        {
            MinStack stack = new MinStack();
            stack.Push(10);
            stack.Push(20);
            Assert.Equal(10, stack.GetMin());

            stack.Push(5);
            Assert.Equal(5, stack.GetMin());
        }

        [Fact]
        public void Test_IsEmpty()
        {
            MinStack stack = new MinStack();
            Assert.True(stack.IsEmpty());

            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void Test_Top()
        {
            MinStack stack = new MinStack();
            stack.Push(10);
            stack.Push(20);
            Assert.Equal(20, stack.Top());

            stack.Pop();
            Assert.Equal(10, stack.Top());
        }
    }
}
