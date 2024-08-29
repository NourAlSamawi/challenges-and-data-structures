using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;
namespace Stack_QueueTests
{
    public class QueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            var queue = new Queue();
            queue.Enqueue(10);
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void TestDequeue()
        {
            var queue = new Queue();
            queue.Enqueue(10);
            int value = queue.Dequeue();
            Assert.Equal(10, value);
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestIsEmpty()
        {
            var queue = new Queue();
            Assert.True(queue.IsEmpty());
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
        }
    }

}
