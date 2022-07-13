using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algs.Core.Fundamentals.Queue;

namespace Algs.UnitTests.Fundamentals.Queue
{
    public class Interator
    {
        [Theory]
        [InlineData(new string[] { "Test1", "Test2", "Test3" }, "Test1Test2Test3")]
        public void LinkedList_ShouldReturnCorrectOrder(string[] input, string output)
        {
            var queue = new LinkedListQueue<string>();
            var result = "";

            foreach (var item in input)
            {
                queue.Enqueue(item);
            }

            while(!queue.IsEmpty())
                result += queue.Dequeue();

            Assert.Equal(output, result);
        }
    }
}
