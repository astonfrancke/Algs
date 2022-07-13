using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Stack;

namespace Algs.UnitTests.Fundamentals.Stack
{
    public class Pop
    {
        private IStack<string> _testStack;
        private static LinkedListStack<string> CreateLinkedListStack()
        {
            return new LinkedListStack<string>();
        }

        private static ResizingArrayStack<string> CreateResizingArrayStack()
        {
            return new ResizingArrayStack<string>();
        }

        [Fact]
        public void LinkedList_ShouldReturnItemAtTopAndDecreaseSize()
        {
            _testStack = CreateLinkedListStack();

            _testStack.Push("Test");

            Assert.Equal(1, _testStack.Size());
            Assert.Equal("Test", _testStack.Peek());

            var item = _testStack.Pop();

            Assert.Equal(0, _testStack.Size());
            Assert.Equal("Test", item);
        }

        [Fact]
        public void LinkedList_ShouldThrowEmptyStackOperationException_WhenStackIsEmpty()
        {
            _testStack = CreateLinkedListStack();

            var popFromStackCall = () => _testStack.Pop();

            Assert.Throws<EmptyStackOperationException>(popFromStackCall);
        }

        [Fact]
        public void ResizingArray_ShouldReturnItemAtTopAndDecreaseSize()
        {
            _testStack = CreateResizingArrayStack();

            _testStack.Push("Test");

            Assert.Equal(1, _testStack.Size());
            Assert.Equal("Test", _testStack.Peek());

            var item = _testStack.Pop();

            Assert.Equal(0, _testStack.Size());
            Assert.Equal("Test", item);
        }

        [Fact]
        public void ResizingArray_ShouldThrowEmptyStackOperationException_WhenStackIsEmpty()
        {
            _testStack = CreateResizingArrayStack();

            var popFromStackCall = () => _testStack.Pop();

            Assert.Throws<EmptyStackOperationException>(popFromStackCall);
        }

    }
}
