using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Stack;

namespace Algs.UnitTests.Fundamentals.Stack
{
    public class Interator
    {
        [Theory]
        [InlineData(new string[] { "Test1", "Test2", "Test3" }, "Test3Test2Test1")]
        public void LinkedList_ShouldReturnCorrectOrder(string[] input, string output)
        {
            var stack = new LinkedListStack<string>();
            var result = "";

            foreach (var item in input)
            {
                stack.Push(item);
            }

            while(!stack.IsEmpty())
                result += stack.Pop();

            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new string[] { "Test1", "Test2", "Test3" }, "Test3Test2Test1")]
        public void ResizingArray_ShouldReturnCorrectOrder(string[] input, string output)
        {
            var stack = new ResizingArrayStack<string>();
            var result = "";

            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (!stack.IsEmpty())
                result += stack.Pop();

            Assert.Equal(output, result);
        }
    }
}
