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
        private Core.Fundamentals.Stack.Stack<string> CreateStack()
        {
            return new Core.Fundamentals.Stack.Stack<string>();
        }

        [Fact]
        public void ShouldReturnItemAtTopAndDecreaseSize()
        {
            _testStack = CreateStack();

            _testStack.Push("Test");

            Assert.Equal(1, _testStack.Size());
            Assert.Equal("Test", _testStack.Peek());

            var item = _testStack.Pop();

            Assert.Equal(0, _testStack.Size());
            Assert.Equal("Test", item);
        }

        [Fact]
        public void ShouldThrowEmptyStackOperationException_WhenStackIsEmpty()
        {
            _testStack = CreateStack();

            var popFromStackCall = () => _testStack.Pop();

            Assert.Throws<EmptyStackOperationException>(popFromStackCall);
        }
    }
}
