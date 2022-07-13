using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        private int _n;
        public LinkedListQueue()
        {
            _head = null;
            _tail = null;
            _n = 0;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new EmptyQueueOperationException("Queue is empty");
            }

            var item = _head.Value;

            _head = _head.Next;

            if (IsEmpty())
            {
                _tail = null;
            }

            _n--;
            
            return item;
        }

        public void Enqueue(T item)
        {
            var oldTail = _tail;
            _tail = new Node<T>(item);
            if (IsEmpty())
            {
                _head = _tail;
            }
            else
            {
                oldTail.Next = _tail;
            }
            _n++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public T Peek()
        {
            return IsEmpty() ? throw new EmptyQueueOperationException("Queue is empty") : _head.Value;
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
