using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Stack;

namespace Algs.UnitTests.Fundamentals.Stack
{
    public class Constructor
    {
        [Fact]
        public void LinkedList_ShouldReturnNewEmptyStack()
        {
            var stack = new LinkedListStack<int>();

            Assert.Equal(0, stack.Size());
            Assert.Empty(stack);
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void ResizingArray_ShouldReturnNewEmptyStack()
        {
            var stack = new ResizingArrayStack<int>();

            Assert.Equal(0, stack.Size());
            Assert.True(stack.IsEmpty());
        }
    }
}
