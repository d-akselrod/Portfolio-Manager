using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Portfolio_Manager
{
    internal class Equity
    {
        private string ticker;
        private double price;

        private int numShares;
        private double avgCost;

        public Equity(string ticker, int numShares, double avgCost)
        {
            this.ticker = ticker;
            this.numShares = numShares;
            this.avgCost = avgCost;
            price = 100;
        }

        public Equity(string ticker, int numShares, double avgCost, double price)
        {
            this.ticker = ticker;
            this.numShares = numShares;
            this.avgCost = avgCost;
            this.price = price;
        }

        public void AddShares(int numShares, double cost)
        {
            this.numShares += numShares;

            avgCost = (avgCost + cost) / this.numShares;
        }

        public void RemoveShares(int numShares)
        {
            this.numShares -= numShares;
        }

        public double UpdatePrice()
        {
            price = 10;
            price = AVConnection.GetEquityPrice(ticker);
            return price;
        }

        public double GetAvgCost()
        {
            return avgCost;
        }

        public int GetNumShares()
        {
            return numShares;
        }

        public double GetValue()
        {
            return numShares * price;
        }

        public double GetNetChange()
        {
            return (price - avgCost) * numShares;
        }

        public double GetPercentChange()
        {
            return (price - avgCost) / avgCost;
        }

        public double GetPercentPortfolio(double portValue)
        {
            return GetValue() / portValue;
        }

        public ListViewItem ToListViewItem(double portfolioValue)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(ticker);
            item.SubItems.Add(FormatConverter.ToMoneyFormat(price));
            item.SubItems.Add(numShares.ToString());
            item.SubItems.Add(FormatConverter.ToMoneyFormat(avgCost));
            item.SubItems.Add(FormatConverter.ToMoneyFormat(GetValue()));
            item.SubItems.Add(FormatConverter.ToMoneyFormat(GetNetChange(), true));
            item.SubItems.Add(FormatConverter.ToPercentFormat(GetPercentChange(), true));
            item.SubItems.Add(FormatConverter.ToPercentFormat(GetPercentPortfolio(portfolioValue)));

            return item;
        }

        public string GetFileOutput()
        {
            return "E" + ","+ ticker + "," + numShares + "," + avgCost + "," + price;
        }
    }
}
