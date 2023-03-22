using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Portfolio_Manager
{
    public partial class PortfolioManager : Form
    {
        private string portfolioPath;
        private Portfolio portfolio;
        private List<Symbol> symbols;
        private int updateIndex = 0;
        
        public PortfolioManager()
        {
            InitializeComponent();
        }

        private void PortfolioManager_Activated(object sender, EventArgs e)
        {
            portfolioPath = "portfolio.txt";
            portfolio = new Portfolio();
            ImportPortfolio();
            LoadSymbols();

            HideAllTabsOnTabControl(tabControlMain);
            tabControlMain.SelectedTab = TPOpeningPage;

            //Test();
            UpdateListViews();
        }

        private void SavePortfolio()
        {
            StreamWriter outFile = File.CreateText(portfolioPath);

            for (int i = 0; i < portfolio.equities.Count + portfolio.currencies.Count; i++)
            {
                //Equity is Portoflio
                if(i < portfolio.equities.Count)
                {
                    outFile.WriteLine(portfolio.equities[i].GetFileOutput());
                }
                //Equity is Currency
                else
                {
                    outFile.WriteLine(portfolio.currencies[i - portfolio.equities.Count].GetFileOutput());
                }
            }

            outFile.Close();
            Console.WriteLine("Saved");
        }

        private void LoadSymbols()
        {
            symbols = new List<Symbol>();
            StreamReader inFile = File.OpenText("companies.txt");
            string[] lineData;

            while (inFile.EndOfStream == false)
            {
                try
                {
                    string line = inFile.ReadLine();
                    lineData = line.Split('\t');

                    symbols.Add(new Symbol(lineData[0], lineData[1]));
                }
                catch
                {
                    continue;
                }
            }
        }
    
        private void ImportPortfolio()
        {
            portfolio.equities.Clear();
            portfolio.currencies.Clear();

            StreamReader inFile = File.OpenText(portfolioPath);
            string[] lineData;

            while(inFile.EndOfStream == false)
            {
                try
                {
                    string line = inFile.ReadLine();
                    lineData = line.Split(',');

                    if (lineData[0].Equals("E"))
                    {
                        portfolio.equities.Add(new Equity(lineData[1], Convert.ToInt32(lineData[2]), Convert.ToDouble(lineData[3]), Convert.ToDouble(lineData[4])));
                    }
                    else
                    {
                        portfolio.currencies.Add(new Currency(lineData[1], Convert.ToDouble(lineData[2])));
                    }

                }
                catch
                {
                    continue; 
                }
            }
        }

        private void HideAllTabsOnTabControl(TabControl theTabControl)
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void UpdateListViews()
        {
            lstEquities.Items.Clear();
            lstCurrencies.Items.Clear();

            foreach(Equity equity in portfolio.equities)
            {
                lstEquities.Items.Add(equity.ToListViewItem(portfolio.GetValue()));
            }

            foreach(Currency currency in portfolio.currencies)
            {
                lstCurrencies.Items.Add(currency.ToListViewItem(portfolio.GetValue()));
            }
        }

        private void allHoldingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = TPViewHoldings;

            lblNumEquities.Text = "Equities: " + portfolio.equities.Count.ToString();
            lblEqVal.Text = "Equity Value: " + FormatConverter.ToMoneyFormat(portfolio.GetEquityValue());
            lblCashVal.Text = "Cash Value: " + FormatConverter.ToMoneyFormat(portfolio.GetCashValue());
            lblPortVal.Text = "Portfolio Value: " + FormatConverter.ToMoneyFormat(portfolio.GetValue());
            lblNetChange.Text = "Net Gain/Loss: " + FormatConverter.ToMoneyFormat(portfolio.GetNetChange());
            lblPercentChange.Text = "Percent Gain/Loss: " + FormatConverter.ToPercentFormat(portfolio.GetPercentChange());
        }

        private void tmrAPITimer_Tick(object sender, EventArgs e)
        {
            if(updateIndex < portfolio.equities.Count)
            {
                portfolio.equities[updateIndex].UpdatePrice();
                pgbRefreshPrices.Increment(1);  
            }


            updateIndex += 1;

            if(updateIndex == portfolio.equities.Count)
            {
                tmrAPITimer.Stop();
                updateIndex = 0;
                btnRefreshPrices.Enabled = true;
                btnRefreshPrices.Text = "Refresh Prices";
                pgbRefreshPrices.Visible = false;

                for(int i = 0; i < portfolio.equities.Count; i++)
                {
                    lstEquities.Items[i] = portfolio.equities[i].ToListViewItem(portfolio.GetValue());
                }
                lstEquities.Update();

            }
        }

        private void btnRefreshPrices_Click(object sender, EventArgs e)
        {
            pgbRefreshPrices.Maximum = portfolio.equities.Count;
            pgbRefreshPrices.Value = 0;
            tmrAPITimer.Start();
            btnRefreshPrices.Enabled = false;
            btnRefreshPrices.Text = "UPDATING";
            pgbRefreshPrices.Visible = true;
        }

        private void savePortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePortfolio();
        }

        private void buyEquityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = TPAddEquity;
            TPAddEquity.Update();
            foreach(Symbol symbol in symbols)
            {
                lstSymbols.Items.Add(symbol.ToListViewItem());
            }
            lstSymbols.Update();
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            lstSymbols.Items.Clear();
            foreach (Symbol symbol in symbols)
            {
                if (symbol.GetTicker().ToLower().Contains(txtAddTicker.Text))
                {
                    lstSymbols.Items.Add(symbol.ToListViewItem());
                }
            }
            foreach (Symbol symbol in symbols)
            {
                if (symbol.GetName().ToLower().Contains(txtAddTicker.Text))
                {
                    lstSymbols.Items.Add(symbol.ToListViewItem());
                }
            }
            
            lstSymbols.Update();
        }

        private void txtAddTicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && txtAddTicker.Text.Length > 0)
            {
                btnFilterSearch.PerformClick();
            }
        }
    }
}
