using System;
using System.Runtime.Serialization;

namespace Shar.CLI
{
    [Serializable]
    internal class CliOptionNotFoundException : Exception
    {
        private string v;
        public string optionName;

        public CliOptionNotFoundException()
        {
        }

        public CliOptionNotFoundException(string message) : base(message)
        {
        }

        public CliOptionNotFoundException(string v, string optionName)
        {
            this.v = v;
            this.optionName = optionName;
        }

        public CliOptionNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CliOptionNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}