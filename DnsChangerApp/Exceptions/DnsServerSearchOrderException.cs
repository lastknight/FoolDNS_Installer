using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace DnsChanger.Exceptions
{
    /// <remarks>An invalid server string was used.</remarks>
    [Serializable]
    public class DnsServerSearchOrderException : Exception
    {
        /// <summary>The code returned from SetDNSServerSearchOrder</summary>
        public uint Code { get; set; }

        /// <summary>Create the exception. We will always have an innerException here.</summary>
        /// <param name="server">The name of the dns server that was deemed invalid.</param>
        /// <param name="innerException">The exception thrown when this server was tested.</param>
        public DnsServerSearchOrderException(uint code) :
            base(string.Format(CultureInfo.InvariantCulture, "Unexpected error when calling SetDNSServerSearchOrder. Code = {0}", code))
        {
            Code = code;
        }

        #region Code Analysis stuff

        #region System.Exception constructors

        public DnsServerSearchOrderException()
        {
        }

        public DnsServerSearchOrderException(string message): base(message)
        {
        }

        public DnsServerSearchOrderException(string message, Exception innerException) :
            base (message, innerException)
        {
        }

        protected DnsServerSearchOrderException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }

        #endregion System.Exception constructors

        #region ISerializable

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("Code", Code);
        }

        #endregion ISerializable

        #endregion Code Analysis stuff
    }
}
