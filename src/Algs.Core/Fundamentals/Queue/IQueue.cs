using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals.Queue
{
    public interface IQueue<T> : IEnumerable<T>
    {
        public void Enqueue(T item);
        public T Dequeue();
        public bool IsEmpty();
        public T Peek();
        public int Size();
    }
}
