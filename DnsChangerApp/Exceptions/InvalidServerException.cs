using System;
using System.Runtime.Serialization;

namespace DnsChanger.Exceptions
{
    /// <remarks>An invalid server string was used.</remarks>
    [Serializable]
    public class InvalidServerException : Exception
    {
        /// <summary>Create the exception. We will always have an innerException here.</summary>
        /// <param name="server">The name of the dns server that was deemed invalid.</param>
        /// <param name="innerException">The exception thrown when this server was tested.</param>
        public InvalidServerException(string server, Exception innerException) :
            base(server, innerException)
        {
        }

        #region Code Analysis stuff

        #region System.Exception constructors

        public InvalidServerException()
        {
        }

        public InvalidServerException(string message): base(message)
        {
        }

        protected InvalidServerException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }

        #endregion System.Exception constructors

        #endregion Code Analysis stuff
}
}
