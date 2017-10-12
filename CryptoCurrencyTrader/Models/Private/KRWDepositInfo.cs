using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class KRWDepositInfo
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("account")]
        public string Account { get; set; }
        [JsonProperty("bank")]
        public string bank { get; set; }
        [JsonProperty("BankUser")]
        public string BankUser { get; set; }
    }
}
