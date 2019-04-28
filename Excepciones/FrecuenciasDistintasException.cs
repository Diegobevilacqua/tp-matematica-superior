using System;
using System.Runtime.Serialization;

namespace NCOM.Operaciones_básicas
{
    [Serializable]
    internal class FrecuenciasDistintasException : Exception
    {
        public FrecuenciasDistintasException()
        {
        }

        public FrecuenciasDistintasException(string message) : base(message)
        {
        }

        public FrecuenciasDistintasException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FrecuenciasDistintasException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}