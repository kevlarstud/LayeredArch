using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    //Customer Exception Class

    public class CustomerException:ApplicationException
    {
        //Default Constructor
        public CustomerException()
        { }
        //Parameterized Constructor which take one string parameter

        public CustomerException(string message): base(message)
        { }
        //Parameterized Constructor which takes two string parameter
        public CustomerException(string message,Exception innerException):base(message,innerException)
        { }
        
    }
}
