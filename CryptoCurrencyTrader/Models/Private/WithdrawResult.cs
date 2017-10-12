using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class WithdrawResult
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
