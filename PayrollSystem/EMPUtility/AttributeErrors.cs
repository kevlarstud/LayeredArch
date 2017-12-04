using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPUtility
{
 public   class AttributeErrors
    {
        private List<ErrorMessage> errorList = new List<ErrorMessage>();

        public List<ErrorMessage> ErrorList
        {
            get { return errorList; }
            set { errorList = value; }
        }
    }
}
