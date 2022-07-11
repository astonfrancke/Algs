using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.UnitTests.Fundamentals.Stack
{
    public class Constructor
    {
        [Fact]
        public void ShouldReturnNewEmptyStack()
        {
            var stack = new Core.Fundamentals.Stack.Stack<int>();

            Assert.Equal(0, stack.Size());
            Assert.True(stack.IsEmpty());
        }
    }
}
