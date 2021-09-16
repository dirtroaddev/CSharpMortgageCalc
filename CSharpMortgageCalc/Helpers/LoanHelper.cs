using CSharpMortgageCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpMortgageCalc.Helpers
{
    public class LoanHelper
    {
        public Loan GetPayments(Loan loan)
        {

            //Calculate my Monthly Payment
            loan.Payment = CalcPayment(loan.Amount, loan.Rate, loan.Term);

            //Create Loop from 1 to the term
            var balance = loan.Amount;
            var totalInterest = 0.0m;
            var monthlyInterest = 0.0m;
            var monthlyPrinciple = 0.0m;
            var monthlyRate = CalcMonthlyRate(loan.Rate);

            //Loop over each month until we reach the term
            for (int month = 0; month <= loan.Term; month++)
            {

            }
            //Calculate a payment schedule

            //Push payments into the loan


            return loan;
        }

        private decimal CalcPayment(decimal amount, decimal rate, int term)
        {


            var monthlyRate = CalcMonthlyRate(rate);
            var rateD = Convert.ToDouble(monthlyRate);
            var amountD = Convert.ToDouble(amount);
            var paymentD = (amountD * rateD) / (1 - Math.Pow(1+rateD, -term));


            return Convert.ToDecimal(paymentD);
        }


        private decimal CalcMonthlyRate(decimal rate)
        {

            return rate / 1200;

        }
    }
}
