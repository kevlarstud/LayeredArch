using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AdmissionException : ApplicationException
    {
        public AdmissionException()
        {

        }
        public AdmissionException(string Exception) : base(Exception)
        {

        }
        public AdmissionException(string message, Exception innerException) : base(message)
        {

        }
    }
    
}
