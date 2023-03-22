using System.Windows.Forms;

namespace Portfolio_Manager
{
    internal class Symbol
    {
        private string ticker;
        private string name;

        public Symbol(string ticker, string name)
        {
            this.ticker = ticker;
            this.name = name;
        }

        public string GetTicker()
        {
            return ticker;
        }

        public string GetName()
        {
            return name;
        }

        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(ticker);
            item.SubItems.Add(name);
            return item;  
        }
   }
}
