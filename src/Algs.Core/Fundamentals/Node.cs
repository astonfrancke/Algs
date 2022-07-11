using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals
{
    public class Node<T>
    {
        public Node<T>? Next { get; set; }
        public T Value { get; }

        public Node(T val)
        {
            Value = val;
        }
    }
}
