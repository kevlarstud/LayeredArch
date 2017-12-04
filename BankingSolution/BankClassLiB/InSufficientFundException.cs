using System;


namespace BankClassLiB
{
 public   class InSufficientFundException :ApplicationException
 {
     #region Contructor
     public InSufficientFundException(): base()
     {

     }
     public InSufficientFundException(string message ): base(message)
     {

     }
     public InSufficientFundException(string message, Exception innerException): 
         base(message,innerException)
     {

     }
     #endregion
 }
}
