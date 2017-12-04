using System;
using EmpEnt;

namespace EmpBAL
{
    public class EmpinfoBAL
    {
        #region Field
        private decimal _hra;
        private decimal _da;
        private decimal _pf;
        private decimal _gross;
        private decimal _net;
        #endregion
        #region Property
        public decimal HRA { get { return _hra; } }
        public decimal DA { get { return _da; } }
        public decimal PF { get { return _pf; } }
        public decimal GROSS { get { return _gross; } }
        public decimal NET { get { return _net; } }
        #endregion
        #region Method
        public  decimal mCalcGross(EmpBEntity entobj)
        {
            _hra = (entobj.BASIC) * (decimal)(0.30);
            _da = (entobj.BASIC) * (decimal) .40;
            _gross = entobj.BASIC + _hra + _da;
            return _gross;
        }
        public decimal mCalcPF(EmpBEntity entobj)
        {
            _pf = (entobj.BASIC) * (decimal).12;
            return _pf;
        }
        public decimal mCalcNet(EmpBEntity entobj)
        {
            _net = _gross - _pf;
            return _net;
        }
        #endregion
        #region Constructor

        #endregion
        
    }
}
