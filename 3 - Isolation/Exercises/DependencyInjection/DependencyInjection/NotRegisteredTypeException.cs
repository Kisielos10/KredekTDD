using System;

namespace DependencyInjection
{
    public class NotRegisteredTypeException : Exception
    {
        public NotRegisteredTypeException(string message) : base(message)
        {
        }
    }
}
