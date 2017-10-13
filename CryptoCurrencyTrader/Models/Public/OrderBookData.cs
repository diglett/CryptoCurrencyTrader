using System;
using System.Collections.Generic;
using CryptoCurrencyTrader.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoCurrencyTrader.Models.Public
{
    public class OrderBookData
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

        public override string ToString()
        {
            var bids = new JArray();

            foreach (var bid in Bids)
            {
                bids.Add(new JObject
                {
                    {"Quantity", bid.Quantity},
                    {"Price", bid.Price}
                });
            }

            var asks = new JArray();

            foreach (var ask in Bids)
            {
                asks.Add(new JObject
                {
                    {"Quantity", ask.Quantity},
                    {"Price", ask.Price}
                });
            }

            var jsonObject = new JObject
            {
                {"TimeStamp", FormattedDateTime.ToString("yyyy-MM-dd HH:mm:ss")},
                {"OrderCurrency", OrderCurrency},
                {"PaymentCurrency", PaymentCurrency},
                {"Bids", bids},
                {"Asks", asks}
            };

            return jsonObject.ToString();
        }
    }
}
