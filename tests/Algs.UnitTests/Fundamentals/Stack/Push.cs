using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.UnitTests.Fundamentals.Stack
{
    public class Push
    {
        private Core.Fundamentals.Stack.IStack<string> _testStack;

        private Core.Fundamentals.Stack.Stack<string> CreateStack()
        {
            return new Core.Fundamentals.Stack.Stack<string>();
        }

        [Theory]
        [InlineData(new string[] { "Test" }, 1)]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, 3)]
        public void ShouldIncreaseSizeByOne(string[] input, int output)
        {
            _testStack = CreateStack();

            foreach (string item in input)
            {
                _testStack.Push(item);
            }

            Assert.Equal(output, _testStack.Size());
        }

        [Theory]
        [InlineData(new string[] { "Test" }, "Test")]
        [InlineData(new string[] { "Test", "Test2", "Test3" }, "Test3")]
        public void ShouldPlacePushedItemAtTop(string[] input, string output)
        {
            _testStack = CreateStack();

            foreach (string item in input)
            {
                _testStack.Push(item);
            }

            Assert.Equal(output, _testStack.Peek());
        }
    }
}
