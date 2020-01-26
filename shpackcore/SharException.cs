using System;
using System.Runtime.Serialization;

namespace Shar.Core
{
    [Serializable]
    public class SharException : Exception
    {
        public SharException()
        {
        }

        public SharException(string message) : base(message)
        {
        }

        public SharException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SharException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}