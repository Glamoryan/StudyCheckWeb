using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace StudyCheck.Utilities.CustomExceptions
{
    public class InvalidAccountException:Exception
    {
        public InvalidAccountException() : base()
        { }
        public InvalidAccountException(String Mesaj) : base(Mesaj)
        { }
        public InvalidAccountException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        { }
        protected InvalidAccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
