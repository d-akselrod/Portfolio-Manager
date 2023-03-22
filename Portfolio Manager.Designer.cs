namespace Portfolio_Manager
{
    partial class PortfolioManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioManager));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPortfilioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyEquityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellEquityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEquityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawCashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allHoldingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMarketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.TPViewHoldings = new System.Windows.Forms.TabPage();
            this.pgbRefreshPrices = new System.Windows.Forms.ProgressBar();
            this.btnRefreshPrices = new System.Windows.Forms.Button();
            this.lblPortVal = new System.Windows.Forms.Label();
            this.lblPercentChange = new System.Windows.Forms.Label();
            this.lblNetChange = new System.Windows.Forms.Label();
            this.lblCashVal = new System.Windows.Forms.Label();
            this.lblEqVal = new System.Windows.Forms.Label();
            this.lblNumEquities = new System.Windows.Forms.Label();
            this.lstCurrencies = new System.Windows.Forms.ListView();
            this.NullHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Currency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.USDVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percentPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstEquities = new System.Windows.Forms.ListView();
            this.NullColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvgCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mrktVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NetChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PercentChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortfolioPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TPOpeningPage = new System.Windows.Forms.TabPage();
            this.lblOpeningPagePGB = new System.Windows.Forms.Label();
            this.pgbOpeningPage = new System.Windows.Forms.ProgressBar();
            this.TPAddEquity = new System.Windows.Forms.TabPage();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.lstSymbols = new System.Windows.Forms.ListView();
            this.chNull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTicker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCompName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAddShares = new System.Windows.Forms.TextBox();
            this.txtAddAvgCost = new System.Windows.Forms.TextBox();
            this.txtAddTicker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrAPITimer = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.TPViewHoldings.SuspendLayout();
            this.TPOpeningPage.SuspendLayout();
            this.TPAddEquity.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(804, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePortfolioToolStripMenuItem,
            this.swapPortfolioToolStripMenuItem,
            this.importPortfilioToolStripMenuItem,
            this.exportPortfolioToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // savePortfolioToolStripMenuItem
            // 
            this.savePortfolioToolStripMenuItem.Name = "savePortfolioToolStripMenuItem";
            this.savePortfolioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.savePortfolioToolStripMenuItem.Text = "Save Portfolio";
            this.savePortfolioToolStripMenuItem.Click += new System.EventHandler(this.savePortfolioToolStripMenuItem_Click);
            // 
            // swapPortfolioToolStripMenuItem
            // 
            this.swapPortfolioToolStripMenuItem.Name = "swapPortfolioToolStripMenuItem";
            this.swapPortfolioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.swapPortfolioToolStripMenuItem.Text = "Swap Portfolio";
            // 
            // importPortfilioToolStripMenuItem
            // 
            this.importPortfilioToolStripMenuItem.Name = "importPortfilioToolStripMenuItem";
            this.importPortfilioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.importPortfilioToolStripMenuItem.Text = "Import Portfilio";
            // 
            // exportPortfolioToolStripMenuItem
            // 
            this.exportPortfolioToolStripMenuItem.Name = "exportPortfolioToolStripMenuItem";
            this.exportPortfolioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportPortfolioToolStripMenuItem.Text = "Export Portfolio";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equityToolStripMenuItem,
            this.cashToolStripMenuItem1,
            this.portfolioToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // equityToolStripMenuItem
            // 
            this.equityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyEquityToolStripMenuItem,
            this.sellEquityToolStripMenuItem,
            this.modifyEquityToolStripMenuItem});
            this.equityToolStripMenuItem.Name = "equityToolStripMenuItem";
            this.equityToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.equityToolStripMenuItem.Text = "Equity";
            // 
            // buyEquityToolStripMenuItem
            // 
            this.buyEquityToolStripMenuItem.Name = "buyEquityToolStripMenuItem";
            this.buyEquityToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.buyEquityToolStripMenuItem.Text = "Add Equity";
            this.buyEquityToolStripMenuItem.Click += new System.EventHandler(this.buyEquityToolStripMenuItem_Click);
            // 
            // sellEquityToolStripMenuItem
            // 
            this.sellEquityToolStripMenuItem.Name = "sellEquityToolStripMenuItem";
            this.sellEquityToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sellEquityToolStripMenuItem.Text = "Remove Equity";
            // 
            // modifyEquityToolStripMenuItem
            // 
            this.modifyEquityToolStripMenuItem.Name = "modifyEquityToolStripMenuItem";
            this.modifyEquityToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modifyEquityToolStripMenuItem.Text = "Modify Equity";
            // 
            // cashToolStripMenuItem1
            // 
            this.cashToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCashToolStripMenuItem,
            this.withdrawCashToolStripMenuItem,
            this.modifyCurrencyToolStripMenuItem});
            this.cashToolStripMenuItem1.Name = "cashToolStripMenuItem1";
            this.cashToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.cashToolStripMenuItem1.Text = "Cash";
            // 
            // addCashToolStripMenuItem
            // 
            this.addCashToolStripMenuItem.Name = "addCashToolStripMenuItem";
            this.addCashToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addCashToolStripMenuItem.Text = "Add Currency";
            // 
            // withdrawCashToolStripMenuItem
            // 
            this.withdrawCashToolStripMenuItem.Name = "withdrawCashToolStripMenuItem";
            this.withdrawCashToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.withdrawCashToolStripMenuItem.Text = "Remove Currency";
            // 
            // modifyCurrencyToolStripMenuItem
            // 
            this.modifyCurrencyToolStripMenuItem.Name = "modifyCurrencyToolStripMenuItem";
            this.modifyCurrencyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modifyCurrencyToolStripMenuItem.Text = "Modify Currency";
            // 
            // portfolioToolStripMenuItem
            // 
            this.portfolioToolStripMenuItem.Name = "portfolioToolStripMenuItem";
            this.portfolioToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.portfolioToolStripMenuItem.Text = "Portfolio";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allHoldingsToolStripMenuItem,
            this.portfolioHistoryToolStripMenuItem,
            this.searchMarketToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allHoldingsToolStripMenuItem
            // 
            this.allHoldingsToolStripMenuItem.Name = "allHoldingsToolStripMenuItem";
            this.allHoldingsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.allHoldingsToolStripMenuItem.Text = "All Holdings";
            this.allHoldingsToolStripMenuItem.Click += new System.EventHandler(this.allHoldingsToolStripMenuItem_Click);
            // 
            // portfolioHistoryToolStripMenuItem
            // 
            this.portfolioHistoryToolStripMenuItem.Name = "portfolioHistoryToolStripMenuItem";
            this.portfolioHistoryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.portfolioHistoryToolStripMenuItem.Text = "Portfolio History";
            // 
            // searchMarketToolStripMenuItem
            // 
            this.searchMarketToolStripMenuItem.Name = "searchMarketToolStripMenuItem";
            this.searchMarketToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.searchMarketToolStripMenuItem.Text = "Search Market";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.TPViewHoldings);
            this.tabControlMain.Controls.Add(this.TPOpeningPage);
            this.tabControlMain.Controls.Add(this.TPAddEquity);
            this.tabControlMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 422);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.TabStop = false;
            // 
            // TPViewHoldings
            // 
            this.TPViewHoldings.BackColor = System.Drawing.Color.White;
            this.TPViewHoldings.Controls.Add(this.pgbRefreshPrices);
            this.TPViewHoldings.Controls.Add(this.btnRefreshPrices);
            this.TPViewHoldings.Controls.Add(this.lblPortVal);
            this.TPViewHoldings.Controls.Add(this.lblPercentChange);
            this.TPViewHoldings.Controls.Add(this.lblNetChange);
            this.TPViewHoldings.Controls.Add(this.lblCashVal);
            this.TPViewHoldings.Controls.Add(this.lblEqVal);
            this.TPViewHoldings.Controls.Add(this.lblNumEquities);
            this.TPViewHoldings.Controls.Add(this.lstCurrencies);
            this.TPViewHoldings.Controls.Add(this.lstEquities);
            this.TPViewHoldings.Location = new System.Drawing.Point(4, 22);
            this.TPViewHoldings.Name = "TPViewHoldings";
            this.TPViewHoldings.Padding = new System.Windows.Forms.Padding(3);
            this.TPViewHoldings.Size = new System.Drawing.Size(768, 396);
            this.TPViewHoldings.TabIndex = 1;
            this.TPViewHoldings.Text = "TPViewHoldings";
            // 
            // pgbRefreshPrices
            // 
            this.pgbRefreshPrices.Location = new System.Drawing.Point(661, 338);
            this.pgbRefreshPrices.Name = "pgbRefreshPrices";
            this.pgbRefreshPrices.Size = new System.Drawing.Size(95, 23);
            this.pgbRefreshPrices.TabIndex = 38;
            this.pgbRefreshPrices.Visible = false;
            // 
            // btnRefreshPrices
            // 
            this.btnRefreshPrices.BackColor = System.Drawing.Color.LightGray;
            this.btnRefreshPrices.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshPrices.Location = new System.Drawing.Point(661, 367);
            this.btnRefreshPrices.Name = "btnRefreshPrices";
            this.btnRefreshPrices.Size = new System.Drawing.Size(95, 23);
            this.btnRefreshPrices.TabIndex = 37;
            this.btnRefreshPrices.Text = "Refresh Prices";
            this.btnRefreshPrices.UseVisualStyleBackColor = false;
            this.btnRefreshPrices.Click += new System.EventHandler(this.btnRefreshPrices_Click);
            // 
            // lblPortVal
            // 
            this.lblPortVal.AutoSize = true;
            this.lblPortVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPortVal.Location = new System.Drawing.Point(512, 290);
            this.lblPortVal.Name = "lblPortVal";
            this.lblPortVal.Size = new System.Drawing.Size(78, 13);
            this.lblPortVal.TabIndex = 36;
            this.lblPortVal.Text = "Portfolio Value:";
            // 
            // lblPercentChange
            // 
            this.lblPercentChange.AutoSize = true;
            this.lblPercentChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPercentChange.Location = new System.Drawing.Point(491, 350);
            this.lblPercentChange.Name = "lblPercentChange";
            this.lblPercentChange.Size = new System.Drawing.Size(99, 13);
            this.lblPercentChange.TabIndex = 35;
            this.lblPercentChange.Text = "Percent Gain/Loss:";
            // 
            // lblNetChange
            // 
            this.lblNetChange.AutoSize = true;
            this.lblNetChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNetChange.Location = new System.Drawing.Point(511, 320);
            this.lblNetChange.Name = "lblNetChange";
            this.lblNetChange.Size = new System.Drawing.Size(79, 13);
            this.lblNetChange.TabIndex = 34;
            this.lblNetChange.Text = "Net Gain/Loss:";
            // 
            // lblCashVal
            // 
            this.lblCashVal.AutoSize = true;
            this.lblCashVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCashVal.Location = new System.Drawing.Point(526, 260);
            this.lblCashVal.Name = "lblCashVal";
            this.lblCashVal.Size = new System.Drawing.Size(64, 13);
            this.lblCashVal.TabIndex = 33;
            this.lblCashVal.Text = "Cash Value:";
            // 
            // lblEqVal
            // 
            this.lblEqVal.AutoSize = true;
            this.lblEqVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqVal.Location = new System.Drawing.Point(521, 230);
            this.lblEqVal.Name = "lblEqVal";
            this.lblEqVal.Size = new System.Drawing.Size(69, 13);
            this.lblEqVal.TabIndex = 32;
            this.lblEqVal.Text = "Equity Value:";
            // 
            // lblNumEquities
            // 
            this.lblNumEquities.AutoSize = true;
            this.lblNumEquities.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumEquities.Location = new System.Drawing.Point(543, 200);
            this.lblNumEquities.Name = "lblNumEquities";
            this.lblNumEquities.Size = new System.Drawing.Size(47, 13);
            this.lblNumEquities.TabIndex = 31;
            this.lblNumEquities.Text = "Equities:";
            // 
            // lstCurrencies
            // 
            this.lstCurrencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NullHeader,
            this.Currency,
            this.Amount,
            this.USDVal,
            this.percentPort});
            this.lstCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrencies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCurrencies.HideSelection = false;
            this.lstCurrencies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstCurrencies.Location = new System.Drawing.Point(21, 201);
            this.lstCurrencies.Name = "lstCurrencies";
            this.lstCurrencies.Size = new System.Drawing.Size(402, 169);
            this.lstCurrencies.TabIndex = 30;
            this.lstCurrencies.UseCompatibleStateImageBehavior = false;
            this.lstCurrencies.View = System.Windows.Forms.View.Details;
            // 
            // NullHeader
            // 
            this.NullHeader.Text = "";
            this.NullHeader.Width = 0;
            // 
            // Currency
            // 
            this.Currency.Text = "Currency";
            this.Currency.Width = 87;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 77;
            // 
            // USDVal
            // 
            this.USDVal.Text = "USD Value";
            this.USDVal.Width = 83;
            // 
            // percentPort
            // 
            this.percentPort.Text = "Percentage of Portfolio";
            this.percentPort.Width = 151;
            // 
            // lstEquities
            // 
            this.lstEquities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NullColumn,
            this.Symbol,
            this.Price,
            this.Shares,
            this.AvgCost,
            this.mrktVal,
            this.NetChange,
            this.PercentChange,
            this.PortfolioPercent});
            this.lstEquities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEquities.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstEquities.HideSelection = false;
            this.lstEquities.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstEquities.Location = new System.Drawing.Point(21, 16);
            this.lstEquities.Name = "lstEquities";
            this.lstEquities.Size = new System.Drawing.Size(723, 169);
            this.lstEquities.TabIndex = 29;
            this.lstEquities.UseCompatibleStateImageBehavior = false;
            this.lstEquities.View = System.Windows.Forms.View.Details;
            // 
            // NullColumn
            // 
            this.NullColumn.Width = 0;
            // 
            // Symbol
            // 
            this.Symbol.Text = "Symbol";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 84;
            // 
            // Shares
            // 
            this.Shares.Text = "Shares";
            this.Shares.Width = 58;
            // 
            // AvgCost
            // 
            this.AvgCost.Text = "Avg Cost";
            this.AvgCost.Width = 67;
            // 
            // mrktVal
            // 
            this.mrktVal.Text = "Market Value";
            this.mrktVal.Width = 103;
            // 
            // NetChange
            // 
            this.NetChange.Text = "Net Change";
            this.NetChange.Width = 83;
            // 
            // PercentChange
            // 
            this.PercentChange.Text = "Percent Change";
            this.PercentChange.Width = 108;
            // 
            // PortfolioPercent
            // 
            this.PortfolioPercent.Text = "Percentage of Portfolio";
            this.PortfolioPercent.Width = 151;
            // 
            // TPOpeningPage
            // 
            this.TPOpeningPage.BackColor = System.Drawing.Color.White;
            this.TPOpeningPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TPOpeningPage.BackgroundImage")));
            this.TPOpeningPage.Controls.Add(this.lblOpeningPagePGB);
            this.TPOpeningPage.Controls.Add(this.pgbOpeningPage);
            this.TPOpeningPage.ForeColor = System.Drawing.Color.CadetBlue;
            this.TPOpeningPage.Location = new System.Drawing.Point(4, 22);
            this.TPOpeningPage.Name = "TPOpeningPage";
            this.TPOpeningPage.Padding = new System.Windows.Forms.Padding(3);
            this.TPOpeningPage.Size = new System.Drawing.Size(768, 396);
            this.TPOpeningPage.TabIndex = 2;
            this.TPOpeningPage.Text = "TPOpeningPage";
            // 
            // lblOpeningPagePGB
            // 
            this.lblOpeningPagePGB.AutoSize = true;
            this.lblOpeningPagePGB.BackColor = System.Drawing.Color.Transparent;
            this.lblOpeningPagePGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningPagePGB.ForeColor = System.Drawing.Color.White;
            this.lblOpeningPagePGB.Location = new System.Drawing.Point(320, 348);
            this.lblOpeningPagePGB.Name = "lblOpeningPagePGB";
            this.lblOpeningPagePGB.Size = new System.Drawing.Size(132, 17);
            this.lblOpeningPagePGB.TabIndex = 1;
            this.lblOpeningPagePGB.Text = "Loading Portfolio";
            this.lblOpeningPagePGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgbOpeningPage
            // 
            this.pgbOpeningPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbOpeningPage.Location = new System.Drawing.Point(3, 368);
            this.pgbOpeningPage.Maximum = 10;
            this.pgbOpeningPage.Name = "pgbOpeningPage";
            this.pgbOpeningPage.Size = new System.Drawing.Size(762, 25);
            this.pgbOpeningPage.Step = 1;
            this.pgbOpeningPage.TabIndex = 0;
            // 
            // TPAddEquity
            // 
            this.TPAddEquity.BackColor = System.Drawing.Color.White;
            this.TPAddEquity.Controls.Add(this.btnFilterSearch);
            this.TPAddEquity.Controls.Add(this.lstSymbols);
            this.TPAddEquity.Controls.Add(this.txtAddShares);
            this.TPAddEquity.Controls.Add(this.txtAddAvgCost);
            this.TPAddEquity.Controls.Add(this.txtAddTicker);
            this.TPAddEquity.Controls.Add(this.label3);
            this.TPAddEquity.Controls.Add(this.label2);
            this.TPAddEquity.Controls.Add(this.label1);
            this.TPAddEquity.Location = new System.Drawing.Point(4, 22);
            this.TPAddEquity.Name = "TPAddEquity";
            this.TPAddEquity.Padding = new System.Windows.Forms.Padding(3);
            this.TPAddEquity.Size = new System.Drawing.Size(768, 396);
            this.TPAddEquity.TabIndex = 3;
            this.TPAddEquity.Text = "TPAddEquity";
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.Location = new System.Drawing.Point(337, 57);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(75, 23);
            this.btnFilterSearch.TabIndex = 32;
            this.btnFilterSearch.Text = "Filter Search";
            this.btnFilterSearch.UseVisualStyleBackColor = true;
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // lstSymbols
            // 
            this.lstSymbols.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNull,
            this.chTicker,
            this.chCompName});
            this.lstSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSymbols.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSymbols.HideSelection = false;
            this.lstSymbols.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstSymbols.Location = new System.Drawing.Point(65, 86);
            this.lstSymbols.Name = "lstSymbols";
            this.lstSymbols.Size = new System.Drawing.Size(621, 169);
            this.lstSymbols.TabIndex = 31;
            this.lstSymbols.UseCompatibleStateImageBehavior = false;
            this.lstSymbols.View = System.Windows.Forms.View.Details;
            // 
            // chNull
            // 
            this.chNull.Text = "";
            this.chNull.Width = 0;
            // 
            // chTicker
            // 
            this.chTicker.Text = "Symbol";
            this.chTicker.Width = 74;
            // 
            // chCompName
            // 
            this.chCompName.Text = "Company";
            this.chCompName.Width = 549;
            // 
            // txtAddShares
            // 
            this.txtAddShares.Location = new System.Drawing.Point(325, 294);
            this.txtAddShares.Name = "txtAddShares";
            this.txtAddShares.Size = new System.Drawing.Size(100, 20);
            this.txtAddShares.TabIndex = 5;
            // 
            // txtAddAvgCost
            // 
            this.txtAddAvgCost.Location = new System.Drawing.Point(325, 320);
            this.txtAddAvgCost.Name = "txtAddAvgCost";
            this.txtAddAvgCost.Size = new System.Drawing.Size(100, 20);
            this.txtAddAvgCost.TabIndex = 4;
            // 
            // txtAddTicker
            // 
            this.txtAddTicker.Location = new System.Drawing.Point(325, 31);
            this.txtAddTicker.Name = "txtAddTicker";
            this.txtAddTicker.Size = new System.Drawing.Size(100, 20);
            this.txtAddTicker.TabIndex = 3;
            this.txtAddTicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddTicker_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(267, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(267, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(294, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Ticker or Company Name";
            // 
            // tmrAPITimer
            // 
            this.tmrAPITimer.Enabled = true;
            this.tmrAPITimer.Interval = 12000;
            this.tmrAPITimer.Tick += new System.EventHandler(this.tmrAPITimer_Tick);
            // 
            // PortfolioManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "PortfolioManager";
            this.Text = "Portfolio Manager";
            this.Activated += new System.EventHandler(this.PortfolioManager_Activated);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.TPViewHoldings.ResumeLayout(false);
            this.TPViewHoldings.PerformLayout();
            this.TPOpeningPage.ResumeLayout(false);
            this.TPOpeningPage.PerformLayout();
            this.TPAddEquity.ResumeLayout(false);
            this.TPAddEquity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swapPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellEquityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawCashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPortfilioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPortfolioToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage TPViewHoldings;
        private System.Windows.Forms.ToolStripMenuItem allHoldingsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Symbol;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Shares;
        private System.Windows.Forms.ColumnHeader mrktVal;
        private System.Windows.Forms.ColumnHeader NetChange;
        private System.Windows.Forms.ColumnHeader PercentChange;
        private System.Windows.Forms.ColumnHeader PortfolioPercent;
        private System.Windows.Forms.ColumnHeader AvgCost;
        private System.Windows.Forms.ListView lstEquities;
        private System.Windows.Forms.ColumnHeader NullColumn;
        private System.Windows.Forms.ListView lstCurrencies;
        private System.Windows.Forms.ColumnHeader NullHeader;
        private System.Windows.Forms.ColumnHeader Currency;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader USDVal;
        private System.Windows.Forms.ColumnHeader percentPort;
        private System.Windows.Forms.ToolStripMenuItem modifyEquityToolStripMenuItem;
        private System.Windows.Forms.Label lblPercentChange;
        private System.Windows.Forms.Label lblNetChange;
        private System.Windows.Forms.Label lblCashVal;
        private System.Windows.Forms.Label lblEqVal;
        private System.Windows.Forms.Label lblNumEquities;
        private System.Windows.Forms.Label lblPortVal;
        private System.Windows.Forms.ToolStripMenuItem modifyCurrencyToolStripMenuItem;
        private System.Windows.Forms.TabPage TPOpeningPage;
        private System.Windows.Forms.TabPage TPAddEquity;
        private System.Windows.Forms.ProgressBar pgbOpeningPage;
        private System.Windows.Forms.Button btnRefreshPrices;
        private System.Windows.Forms.Label lblOpeningPagePGB;
        private System.Windows.Forms.Timer tmrAPITimer;
        private System.Windows.Forms.ProgressBar pgbRefreshPrices;
        private System.Windows.Forms.ToolStripMenuItem searchMarketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyEquityToolStripMenuItem;
        private System.Windows.Forms.ListView lstSymbols;
        private System.Windows.Forms.ColumnHeader chNull;
        private System.Windows.Forms.ColumnHeader chTicker;
        private System.Windows.Forms.ColumnHeader chCompName;
        private System.Windows.Forms.TextBox txtAddShares;
        private System.Windows.Forms.TextBox txtAddAvgCost;
        private System.Windows.Forms.TextBox txtAddTicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterSearch;
    }
}

