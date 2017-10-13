using System;
using System.Collections.Generic;
using CryptoCurrencyTrader.Utils;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Public
{
    public class OrderBook
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public OrderBookData Data { get; set; }
    }
}
