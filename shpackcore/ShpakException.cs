using System;
using System.Runtime.Serialization;

namespace Shpak.Core
{
    [Serializable]
    public class ShpakException : Exception
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