using System;
using System.Runtime.Serialization;

namespace CourseLibrary.API.Controllers
{
    [Serializable]
    internal class ArugementNullException : Exception
    {
        public ArugementNullException()
        {
        }

        public ArugementNullException(string message) : base(message)
        {
        }

        public ArugementNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArugementNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}