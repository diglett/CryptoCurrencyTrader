using System;
using System.Collections.Generic;
using CryptoCurrencyTrader.Utils;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Public
{
    public class OrderBook
    {
        [JsonProperty("timestamp")]
        public long TimeStamp { get; set; }

        [JsonProperty("order_currency")]
        public string OrderCurrency { get; set; }

        [JsonProperty("payment_currency")]
        public string PaymentCurrency { get; set; }

        [JsonProperty("bids")]
        public List<BidAskData> Bids { get; set; }

        [JsonProperty("asks")]
        public List<BidAskData> Asks { get; set; }

        [JsonIgnore]
        public DateTime FormattedDateTime
        {
            get
            {
                return CommonFunctions.ConvertUnixTimeStampToDateTime(TimeStamp);
            }
        }
    }
}
