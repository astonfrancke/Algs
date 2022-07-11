using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals.Stack
{
    public interface IStack<T> : IEnumerable<T>
    {
        public void Push(T item);
        public T Pop();
        public T Peek();
        public bool IsEmpty();
        public int Size();
    }
}
