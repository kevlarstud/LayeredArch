using System;
using BankBEntities;

namespace BankClassLiB
{
  public   delegate void   Onbalancechange(CAccountsEnt accobjent);
 ////[CLSCompliant(true)]
    public  class CSavingAccounts:CAccounts, ICalcInterest
    {
        #region Field
        private decimal _balance;
      //Event Handler
        public event Onbalancechange onbalchange;
        Onbalancechange balchange = new Onbalancechange(SMSAlert);
        #endregion
        #region property
        public decimal BALANCE { get { return _balance; } }
        #endregion
        #region Method
        
      public override void mDeposit(BankBEntities.CAccountsEnt accobj)
        {
            _balance +=accobj.AMOUNT;
            balchange(accobj);
            // Raising the Event
            if (onbalchange!=null)
            {
                onbalchange(accobj);
            }
        }
     

        public override void mWithdraw(BankBEntities.CAccountsEnt accobj)
        {
            if (_balance>5000)
            {
            _balance -=accobj.AMOUNT;
            balchange(accobj);
            // Raising the Event
                if (onbalchange != null)
            {
                onbalchange(accobj);
            }
            }
            else
            {
                throw new InSufficientFundException("You have In Sufficient Funds in your Account");
            }
        }
        public decimal interestcalc(int time, float rate, decimal amt)
        {
           return ((decimal) time* (decimal) rate*amt);
        }
      public static  void SMSAlert(CAccountsEnt accentobj)
        {
            
          Console.WriteLine("SMS Alert");  
          Console.WriteLine("Account No {0} has change in balance ",accentobj.ACCOUNTNO );
        }
        #endregion
        #region Constructor
      
      public CSavingAccounts(CAccountsEnt entobj)
        {
            _balance = entobj.AMOUNT;
        }
        #endregion



       
    }
}
