using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    //Product Exception Class
    public class ProductException:ApplicationException
    {
        //Default Constructor
        public ProductException():base()
        {

        }
        //Parameterized COnstructor which take one string parameter
        public ProductException(string message):base (message)
        {
        }
        //Parameteized Constructor which take two parameters
        public ProductException(string message,Exception innerException):base(message,innerException)
        {

        }
    }
}
