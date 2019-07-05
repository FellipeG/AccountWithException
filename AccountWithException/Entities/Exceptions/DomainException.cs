using System;

namespace AccountWithException.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string msg) : base(msg)
        {
        }
    }
}
