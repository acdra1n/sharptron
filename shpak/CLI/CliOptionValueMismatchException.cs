using System;
using System.Runtime.Serialization;

namespace shpak.CLI
{
    [Serializable]
    internal class CliOptionValueMismatchException : Exception
    {
        private string optionName;
        private CliOptionValueType integer;

        public CliOptionValueMismatchException()
        {
        }

        public CliOptionValueMismatchException(string message) : base(message)
        {
        }

        public CliOptionValueMismatchException(string optionName, CliOptionValueType integer)
        {
            this.optionName = optionName;
            this.integer = integer;
        }

        public CliOptionValueMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CliOptionValueMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}