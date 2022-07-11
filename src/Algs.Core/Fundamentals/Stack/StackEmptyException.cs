using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals.Stack
{
    public class EmptyStackOperationException : Exception
    {
        public EmptyStackOperationException()
        {
        }

        public EmptyStackOperationException(string message)
            : base(message)
        {
        }

        public EmptyStackOperationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
