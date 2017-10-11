using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader
{
    public class OrderBookData
    {
        public TimeSpan TimeStamp { get; set; }

        public string OrderCurrency { get; set; }

        public string PaymentCurrency { get; set; }

        public List<BidAskData> Bids { get; set; }

        public List<BidAskData> Asks { get; set; }
    }
}
