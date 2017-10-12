using System;
using System.Collections.Generic;

namespace CryptoCurrencyTrader.Models.Public
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
