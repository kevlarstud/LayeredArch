using System;
namespace BankClassLiB
{
   public interface ICalcInterest
    {
       decimal interestcalc(int time, float rate, decimal amt);
    }
}
