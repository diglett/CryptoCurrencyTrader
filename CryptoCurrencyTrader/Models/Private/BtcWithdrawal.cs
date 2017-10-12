using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class BtcWithdrawal
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
