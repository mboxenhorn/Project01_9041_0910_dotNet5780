using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class IllegalAttemptException : Exception
    {
        public IllegalAttemptException() : base() { }
        public IllegalAttemptException(string message) : base(message) { }
    }

    public class UnreasonableDetailsException : Exception
    {
        public UnreasonableDetailsException() : base() { }
        public UnreasonableDetailsException(string message) : base(message) { }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }
    }
}
