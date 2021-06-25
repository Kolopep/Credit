using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class LoanData
    {
        public int day;
        public double bet;
        public double accumulative;
        public double paymentAmount;
        public LoanData(int day, double bet, double accumulative, double paymentAmount)
        {
            this.accumulative = accumulative;
            this.paymentAmount = paymentAmount;
            this.day = day;
            this.bet = bet;
        }
    }
}
