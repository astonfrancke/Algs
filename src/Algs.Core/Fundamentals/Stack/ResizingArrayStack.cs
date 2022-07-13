using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals.Stack
{
    public class ResizingArrayStack<T> : IStack<T>
    {
        private T[] _a;
        private int _n;

        public ResizingArrayStack(int size = 1)
        {
            _a = new T[size];
            _n = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _n; i > 0; i--)
            {
                yield return _a[i];
            }
        }

        public bool IsEmpty()
        {
            return _n == 0;
        }

        public T Peek()
        {
            return _a[_n - 1];
        }

        public T Pop()
        {
            if (_n <= 0)
            {
                throw new EmptyStackOperationException("Stack is empty");
            }

            var item = _a[--_n];
            _a[_n] = default(T);

            if (_n == _a.Length/4)
            {
                Resize(_a.Length / 2);
            }

            return item;
        }

        public void Push(T item)
        {
            if (_n == _a.Length)
            {
                Resize(2*_a.Length);
            }
            _a[_n++] = item;
        }

        private void Resize(int max)
        {
            var newStack = new T[max];

            for (int i = 0; i < _n; i++)
            {
                newStack[i] = _a[i];
            }

            _a = newStack;
        }

        public int Size()
        {
            return _n;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
