using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class WalletAddress
    {
        [JsonProperty("wallet_address")]
        public string Address { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
