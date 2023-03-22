using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio_Manager
{
    internal class Currency
    {
        private string symbol;
        private double amount;

        public Currency(string symbol)
        {
            this.symbol = symbol;
            amount = 0;
        }

        public Currency(string symbol, double amount)
        {
            this.symbol = symbol;
            this.amount = amount;
        }

        public void AddCash(double amount)
        {
            this.amount += amount;
        }

        public void RemoveCash(double amount)
        {
            this.amount -= amount;
        }

        public string GetSymbol()
        {
            return symbol;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public double GetUSDValue()
        {
            return amount;
        }

        public double GetPercentPortfolio(double portValue)
        {
            return GetUSDValue() / portValue;
        }

        public ListViewItem ToListViewItem(double portfolioValue)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(symbol);
            item.SubItems.Add(amount.ToString());
            item.SubItems.Add(FormatConverter.ToMoneyFormat(GetUSDValue()));
            item.SubItems.Add(FormatConverter.ToPercentFormat(GetPercentPortfolio(portfolioValue)));

            return item;
        }

        public String GetFileOutput()
        {
            return "C" + "," + symbol + "," + amount;
        }
    }
}
