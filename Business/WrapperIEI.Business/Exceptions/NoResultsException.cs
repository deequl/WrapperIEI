
using System;
using System.Collections.Generic;
using System.Text;

namespace WrapperIEI.Business
{
    [Serializable()]
    public class NoResultsException : System.Exception
    {
        public NoResultsException() : base() { }
        public NoResultsException(string message) : base(message) { }
        public NoResultsException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected NoResultsException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
