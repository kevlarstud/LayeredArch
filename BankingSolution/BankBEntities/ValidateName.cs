using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBEntities
{
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Method,AllowMultiple=true)]
 public   class ValidateName :Attribute
 {
     #region Field
        string _message;
     #endregion
     #region Property
        public string MESSAGE { get { return _message; } set {_message=value ;} }
     #endregion
     #region Method
     public bool IsValid(string name)
        {
            bool flag=false;
            string myname = name;
            if (myname.Equals(name.ToUpper()))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
     #endregion
     #region Constructor
     public ValidateName(string message)
     {
         this._message = message;
     }
     #endregion

 }
}
