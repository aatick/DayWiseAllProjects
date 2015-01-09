using System;

namespace CustomerProfitCalculationApp
{
    internal class Account
    {
        private double capital;
        private int installmentPeriod;
        public Account(double capital, int installmentPeriod)
        {
            this.capital = capital;
            this.installmentPeriod = installmentPeriod;
        }

        public double ProfitPrincipal { get; set; }
        public double Capital
        {
            get { return capital; }
        }

        public double GetProfit(double rate, int nthInstallment)
        {
            double profit=Capital*Math.Pow((1 + (rate/100)), nthInstallment);
            ProfitPrincipal = Capital + profit;
            return profit;
        }
    }
}