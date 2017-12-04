using System;
using BankBEntities;
namespace BankClassLiB
{
    public abstract class CAccounts
    {
        #region Field
      //  private decimal _balance;
        #endregion
        #region Property
       // public decimal BALANCE { get { return _balance; } }
        #endregion
        #region Methods
        public abstract void mDeposit(CAccountsEnt accobj);
        public abstract void mWithdraw(CAccountsEnt accobj);
        #endregion
        #region Constructor

        #endregion


    }
}
