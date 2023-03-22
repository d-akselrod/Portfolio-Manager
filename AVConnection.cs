using System;
using System.Net;
using System.IO;
using Microsoft.Data.Analysis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Manager
{
    internal class AVConnection
    {
        private static string apiKey = "T3K8ZIAU4D4MRSZ3";
        private static string apiKey2 = "4LAOXKBCTD5S7LL3";

        public static double GetEquityPrice(string symbol)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + symbol + "&apikey=" + apiKey + "&datatype=csv");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            reader.ReadLine();
            string results = reader.ReadLine();
            reader.Close();
            //File.WriteAllText("stockdata.csv", results);
            // DataFrame df = DataFrame.LoadCsv("stockdata.csv");
            Console.WriteLine(results);
            //Console.WriteLine(1);
            return Convert.ToDouble(results.Split(',')[4]);
            //return 1;
        }
    }
}
