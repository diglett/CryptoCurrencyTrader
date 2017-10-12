using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Account
    {
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("trade_fee")]
        public string TradeFee { get; set; }
        [JsonProperty("balance")]
        public string Balance { get; set; }
    }
}
