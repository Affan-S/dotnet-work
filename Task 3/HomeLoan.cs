using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class HomeLoan: Expense
    {
        public double TotalDeposit;
        public double InterestRate;
        public int NumberOfMonths;
        public double MonthlyRepayment;

       public double CalculateTotalRepayment(double Price, double Deposit, double InterestRate, int NumberOfMonths)
        {
            double TotalRepayment = (Price - Deposit) * (1 + InterestRate / 100 * NumberOfMonths / 12);

            return TotalRepayment;
        }

    }
}
