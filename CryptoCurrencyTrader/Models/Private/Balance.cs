using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Balance
    {
        [JsonProperty("total_btc")]
        public string TotalBtc { get; set; }
        [JsonProperty("total_krw")]
        public string TotalKrw { get; set; }
        [JsonProperty("in_use_btc")]
        public string InUseBtc { get; set; }
        [JsonProperty("in_use_krw")]
        public string InUseKrw { get; set; }
        [JsonProperty("available_btc")]
        public string AvailableBtc { get; set; }
        [JsonProperty("available_krw")]
        public string AvailableKrw { get; set; }
        [JsonProperty("misu_btc")]
        public string MisuBtc { get; set; }
        [JsonProperty("misu_krw")]
        public string MisuKrw { get; set; }
        [JsonProperty("xcoin_last")]
        public string XcoinLast { get; set; }
        [JsonProperty("misu_depo_krw")]
        public string MisuDepoKrw { get; set; }
    }
}
