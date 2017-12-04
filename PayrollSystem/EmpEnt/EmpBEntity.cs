using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMPUtility;
namespace EmpEnt
{
    public class EmpBEntity:AttributeErrors
    {
        #region Field
        private int _empid;
        private string _empname;
        private decimal _basic;
        #endregion
        #region Property
        public int EMPID { get { return _empid; } set { _empid=value;} }
        public string EMPNAME { get { return _empname; } set {_empname=value ;} }
        [CheckRange(100000,10000,"Basic Salary Can be Between 10000 and 100000")]
        public decimal BASIC { get { return _basic; } set { _basic=value ;} }
        #endregion
        #region Method
        
        #endregion
        #region Constructor
        public EmpBEntity()
        {

        }
        public EmpBEntity(int empid, string empname, decimal basic )
        {
            this._empid = empid;
            this._empname = empname;
            this._basic = basic;
        }
        #endregion
    }
}
