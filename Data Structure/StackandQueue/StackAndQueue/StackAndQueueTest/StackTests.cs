using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;

namespace StackAndQueueTest
{
    public class StackTests
    {
        [Fact]
        public void TestPush()
        {
            var stack = new Stack();
            stack.Push(10);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void TestPop()
        {
            var stack = new Stack();
            stack.Push(10);
            int value = stack.Pop();
            Assert.Equal(10, value);
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestIsEmpty()
        {
            var stack = new Stack();
            Assert.True(stack.IsEmpty());
            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }
    }

}
