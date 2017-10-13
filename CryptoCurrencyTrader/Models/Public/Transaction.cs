using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Public
{
    public class Transaction
    {
        [JsonProperty("transaction_date")]
        public DateTime TransactionDate { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("units_traded")]
        public double UnitsTraded { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
