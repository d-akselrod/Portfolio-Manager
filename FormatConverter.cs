using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Manager
{
    internal class FormatConverter
    {
        public static String ToMoneyFormat(double value)
        {
            return "$ " + value.ToString("0.00");
        }

        public static String ToMoneyFormat(double value, bool sign)
        {
            if (value > 0)
            {
                return "$ +" + value.ToString("0.00");
            }
            return "$ " + value.ToString("0.00");

        }

        public static String ToPercentFormat(double value)
        {
            return Math.Round(100 * value, 2).ToString() + "%";
        }

        public static String ToPercentFormat(double value, bool sign)
        {
            if(value > 0)
            {
                return "+" + Math.Round(100 * value, 2).ToString() + "%";
            }
            return Math.Round(100*value, 2).ToString() + "%";
        }
    }
}
