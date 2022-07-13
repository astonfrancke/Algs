using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Queue;

namespace Algs.UnitTests.Fundamentals.Queue
{
    public class Enqueue
    {
        private IQueue<string> _testQueue;
        private static LinkedListQueue<string> CreateLinkedListQueue()
        {
            return new LinkedListQueue<string>();
        }

        [Theory]
        [InlineData(new string[] { "Test" }, 1)]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, 3)]
        public void LinkedList_ShouldIncreaseSizeByOne(string[] input, int output)
        {
            _testQueue = CreateLinkedListQueue();

            foreach (string item in input)
            {
                _testQueue.Enqueue(item);
            }

            Assert.Equal(output, _testQueue.Size());
        }

        [Theory]
        [InlineData(new string[] { "Test" }, "Test")]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, "Test")]
        public void LinkedList_ShouldPlaceEnqueuedItemLast(string[] input, string output)
        {
            _testQueue = CreateLinkedListQueue();

            foreach (string item in input)
            {
                _testQueue.Enqueue(item);
            }

            Assert.Equal(output, _testQueue.Peek());
        }
    }
}
