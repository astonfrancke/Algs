using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Stack;

namespace Algs.UnitTests.Fundamentals.Stack
{
    public class Push
    {
        private IStack<string> _testStack;

        private LinkedListStack<string> CreateLinkedListStack()
        {
            return new LinkedListStack<string>();
        }

        private ResizingArrayStack<string> CreateResizingArrayStack()
        {
            return new ResizingArrayStack<string>();
        }

        [Theory]
        [InlineData(new string[] { "Test" }, 1)]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, 3)]
        public void LinkedList_ShouldIncreaseSizeByOne(string[] input, int output)
        {
            _testStack = CreateLinkedListStack();

            foreach (string item in input)
            {
                _testStack.Push(item);
            }

            Assert.Equal(output, _testStack.Size());
        }

        [Theory]
        [InlineData(new string[] { "Test" }, "Test")]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, "Test3")]
        public void LinkedList_ShouldPlacePushedItemAtTop(string[] input, string output)
        {
            _testStack = CreateLinkedListStack();

            foreach (string item in input)
            {
                _testStack.Push(item);
            }

            Assert.Equal(output, _testStack.Peek());
        }

        [Theory]
        [InlineData(new string[] { "Test" }, 1)]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, 3)]
        public void ResizingArray_ShouldIncreaseSizeByOne(string[] input, int output)
        {
            _testStack = CreateResizingArrayStack();

            foreach (string item in input)
            {
                _testStack.Push(item);
            }

            Assert.Equal(output, _testStack.Size());
        }

        [Theory]
        [InlineData(new string[] { "Test" }, "Test")]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, "Test3")]
        public void ResizingArray_ShouldPlacePushedItemAtTop(string[] input, string output)
        {
            _testStack = CreateResizingArrayStack();

            foreach (string item in input)
            {
                _testStack.Push(item);
            }

            Assert.Equal(output, _testStack.Peek());
        }
    }
}
