using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Queue;

namespace Algs.UnitTests.Fundamentals.Queue
{
    public class Constructor
    {
        [Fact]
        public void LinkedList_ShouldReturnNewEmptyQueue()
        {
            var stack = new LinkedListQueue<int>();

            Assert.Equal(0, stack.Size());
            Assert.Empty(stack);
            Assert.True(stack.IsEmpty());
        }
    }
}
