using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs.Core.Fundamentals.Queue
{
    public class EmptyQueueOperationException : Exception
    {
        public EmptyQueueOperationException()
        {
        }

        public EmptyQueueOperationException(string message)
            : base(message)
        {
        }

        public EmptyQueueOperationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
