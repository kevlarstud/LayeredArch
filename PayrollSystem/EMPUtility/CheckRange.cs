using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPUtility
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property,AllowMultiple=true)]
  public  class CheckRange: Attribute,IAttributes
    {
      int maxval, minval;
      string _errormessage;
      public CheckRange(int maxval, int minval, string errmsg)
      {
          this.maxval = maxval;
          this.minval = minval;
          _errormessage = errmsg;
      }
      
        public string message
        {
            get
            {
                return _errormessage;
                //throw new NotImplementedException();
            }
            set
            {
                _errormessage = value;
              //  throw new NotImplementedException();
            }
        }

        public bool IsValid(object item)
        {
            bool flag = false;
            decimal basval = (decimal)item;
            if (basval<maxval && basval>minval)
            {
                flag = true;
            }
            return flag;
            //throw new NotImplementedException();
        }
    }
}
