using System;
using CryptoCurrencyTrader.Models.Enums;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class WalletAddress
    {
        [JsonProperty("wallet_address")]
        public string Address { get; set; }
        [JsonProperty("currency")]
        public string CurrencyName { get; set; }

        [JsonIgnore]
        public CurrencyType CurrencyType
        {
            get
            {
                CurrencyType type;
                Enum.TryParse(CurrencyName, out type);

                return type;
            }
        }
    }
}
