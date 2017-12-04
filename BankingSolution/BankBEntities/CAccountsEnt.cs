
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBEntities
{
    public class CAccountsEnt
    {
        #region Field

        #endregion
        #region Property
        public int ACCOUNTNO { get; set; }
       [ValidateName("Name should be in Capital Letters")]
        public string ACC_HOLD_NAME { get; set; }
        public string ACC_TYPE { get; set; }
        public string TRANS_TYPE { get; set; }
        public decimal AMOUNT { get; set; }
        
        #endregion
        #region Methods

        #endregion
        #region Constructor
        public CAccountsEnt()
        {
          
        }
        public CAccountsEnt(int accno, string name, string acctype,string transtype,decimal amt)

        {
            ACCOUNTNO = accno;
            ACC_HOLD_NAME = name;
            ACC_TYPE = acctype;
            TRANS_TYPE = transtype;
            AMOUNT = amt;
          

        }
        #endregion
    }
}
