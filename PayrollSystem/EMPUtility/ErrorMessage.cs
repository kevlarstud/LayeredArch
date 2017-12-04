using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPUtility
{
   public class ErrorMessage
    {
        private string propertyName;

        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }
        private string errorMessage;

        public string ErrorMessage1
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }
        public ErrorMessage()
        {
            this.propertyName = string.Empty;
            this.errorMessage = string.Empty;
        }
        public ErrorMessage(string propname,string errmsg)
        {
            this.propertyName = propname;
            this.errorMessage = errmsg;
        }
    }
}
