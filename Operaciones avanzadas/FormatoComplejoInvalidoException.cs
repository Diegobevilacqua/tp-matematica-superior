using System;
using System.Runtime.Serialization;

namespace NCOM.Operaciones_avanzadas
{
    [Serializable]
    internal class FormatoComplejoInvalidoException : Exception
    {
        public FormatoComplejoInvalidoException()
        {
        }

        public FormatoComplejoInvalidoException(string message) : base(message)
        {
        }

        public FormatoComplejoInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FormatoComplejoInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}