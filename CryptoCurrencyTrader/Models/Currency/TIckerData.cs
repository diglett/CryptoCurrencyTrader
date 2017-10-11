using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader
{
    public class TickerData
    {
        public string OpeningPrice { get; set; }

        public string ClosingPrice { get; set; }

        public string MinPrice { get; set; }

        public string MaxPrice { get; set; }

        public string AveragePrice { get; set; }

        public string UnitsTraded { get; set; }

        public string Volume1Day { get; set; }

        public string Volume7Day { get; set; }

        public string BuyPrice { get; set; }

        public string SellPrice { get; set; }

        public TimeSpan Date { get; set; }
    }
}
