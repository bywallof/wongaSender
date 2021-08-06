using System;

namespace LoaningLibrary
{
    public class Loaning
    {

        /// <summary><c>Loaning</c> strategies used to assist with handing out loans to individuals
        /// </summary>
        ///

        private double amount;
        private int periodInDays;

        public Loaning(double amount, int period) 
        {
            this.amount = amount;
            this.periodInDays = period;
        }

        /// <summary><c>ShouldLoan</c> to determine if the customer is eligible for a loan
        /// </summary>
        ///
        public bool ShouldLoan() 
        {
            if (this.amount <= 0 || this.periodInDays <= 0) 
            {
                throw new WongaException("This loan is not real. Loans above 100 ZAR are allowed only and over a period of 7 days");
            }
            return (this.amount > 5999 || this.periodInDays > 6);
        }
    }
}
