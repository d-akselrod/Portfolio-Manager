using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Manager
{
    internal class CryptoCurrency
    {
        private string coinName;
        private double value;

        public CryptoCurrency(string coinName)
        {
            this.coinName = coinName;
            value = GetValue();
        }

        public double GetValue()
        {
            //API GET<coinName> price call
            value = 0.0;
            return value;
        }
    }
}
