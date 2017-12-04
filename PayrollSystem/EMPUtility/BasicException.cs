using System;


namespace EMPUtility
{
    public class BasicException:ApplicationException
    {
        public BasicException():base()
        {

        }
        public BasicException(string message):base(message)
        {

        }
        public BasicException(string message, Exception innerException):
            base(message,innerException)
        {

        }
    }
}
