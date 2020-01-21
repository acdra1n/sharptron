using System;
using System.Runtime.Serialization;

namespace shpakcore
{
    [Serializable]
    internal class ShpakException : Exception
    {
        public ShpakException()
        {
        }

        public ShpakException(string message) : base(message)
        {
        }

        public ShpakException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ShpakException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}