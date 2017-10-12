using System;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Public
{
    public class Ticker
    {
        public string Status { get; set; }

        public TickerData Data { get; set; }
    }
}
