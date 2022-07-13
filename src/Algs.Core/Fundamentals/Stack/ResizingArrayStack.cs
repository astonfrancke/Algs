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

        private T[] _stack;
        private int _n;

        public ResizingArrayStack(int size = 1)
        {
            _stack = new T[size];
            _n = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _n; i > 0; i--)
            {
                yield return _stack[i];
            }
        }

        public bool IsEmpty()
        {
            return _n == 0;
        }

        public T Peek()
        {
            return _stack[_n - 1];
        }

        public T Pop()
        {
            if (_n <= 0)
            {
                throw new EmptyStackOperationException("Stack is empty");
            }

            var item = _stack[--_n];
            _stack[_n] = default(T);

            if (_n == _stack.Length/4)
            {
                Resize(_stack.Length / 2);
            }

            return item;
        }

        public void Push(T item)
        {
            if (_n == _stack.Length)
            {
                Resize(2*_stack.Length);
            }
            _stack[_n++] = item;
        }

        private void Resize(int max)
        {
            var newStack = new T[max];

            for (int i = 0; i < _n; i++)
            {
                newStack[i] = _stack[i];
            }

            _stack = newStack;
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
