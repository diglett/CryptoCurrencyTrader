using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Public
{
    public class Transactions
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public TransactionData Data { get; set; }
    }
}
