using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Portfolio_Manager
{
    internal class Portfolio
    {
        public List<Equity> equities;
        public List<Currency> currencies;

        private double currentValue;
        private Dictionary<String, double> valueHistory;

        public Portfolio()
        {
            equities = new List<Equity>();
            currencies = new List<Currency>();
        }

        public void AddEquity(Equity newEquity)
        {
            equities.Add(newEquity);
        }

        public void RemoveEquity(Equity remEquity)
        {
            equities.Remove(remEquity);
        }

        public void AddCurrency(Currency currency)
        {
            currencies.Add(currency);
        }

        public void AddCash(Currency currency, double amount)
        {
            currencies[currencies.IndexOf(currency)].AddCash(amount);
        }

        public void RemoveCash(Currency currency, double amount)
        {
            currencies[currencies.IndexOf(currency)].RemoveCash(amount);
        }

        public double GetValue()
        {
            currentValue = GetCashValue() + GetEquityValue(); ;
            return currentValue;
        }

        public double GetNetChange()
        {
            double netChange = 0;

            foreach(Equity equity in equities)
            {
                netChange += equity.GetNetChange();
            }

            return netChange;
        } 

        public double GetPercentChange()
        {
            double totalCost = 0;

            foreach(Equity equity in equities)
            {
                totalCost += equity.GetAvgCost() * equity.GetNumShares();
            }

            Console.WriteLine(GetValue());
            return (GetValue() - (totalCost + GetCashValue())) / (totalCost + GetCashValue());
        }

        public double GetEquityValue()
        {
            double equityVal = 0;
            foreach (Equity equity in equities)
            {
                equityVal += equity.GetValue();
            }

            return equityVal;
        }

        public double GetCashValue()
        {
            double cashVal = 0;
            foreach (Currency currency in currencies)
            {
                cashVal += currency.GetUSDValue();
            }

            return cashVal;
        }
    }
}
