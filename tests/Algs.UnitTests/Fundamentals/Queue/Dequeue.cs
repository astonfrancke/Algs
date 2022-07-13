using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Queue;

namespace Algs.UnitTests.Fundamentals.Queue
{
    public class Dequeue
    {
        private IQueue<string> _testQueue;
        private static LinkedListQueue<string> CreateLinkedListQueue()
        {
            return new LinkedListQueue<string>();
        }

        [Fact]
        public void LinkedList_ShouldReturnLeastRecentlyAddedItemAndDecreaseSize()
        {
            _testQueue = CreateLinkedListQueue();

            _testQueue.Enqueue("Test");

            Assert.Equal(1, _testQueue.Size());
            Assert.Equal("Test", _testQueue.Peek());

            _testQueue.Enqueue("Test2");

            Assert.Equal(2, _testQueue.Size());
            Assert.Equal("Test", _testQueue.Peek());

            var item = _testQueue.Dequeue();

            Assert.Equal(1, _testQueue.Size());
            Assert.Equal("Test", item);
        }

        [Fact]
        public void LinkedList_ShouldThrowEmptyStackOperationException_WhenQueueIsEmpty()
        {
            _testQueue = CreateLinkedListQueue();

            var dequeueCall = () => _testQueue.Dequeue();

            Assert.Throws<EmptyQueueOperationException>(dequeueCall);
        }
    }
}
