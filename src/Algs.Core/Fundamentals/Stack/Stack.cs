using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals.Stack
{
    public class Stack<T> : IStack<T>
    {
        private Node<T>? _head;
        private int _n;

        public Stack()
        {
            _head = null;
            _n = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public T Peek()
        {
            return
                _head == null ? throw new EmptyStackOperationException("Stack is empty") : _head.Value;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new EmptyStackOperationException("Stack is empty");
            }

            var item = _head.Value;

            _head = _head.Next;
            _n--;

            return item;
        }

        public void Push(T item)
        {
            var oldHead = _head;
            
            _head = new Node<T>(item);
            
            if (oldHead != null)
            {
                _head.Next = oldHead;
            }

            _n++;
        }

        public int Size()
        {
            return _n;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
