using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class UserTransaction
    {
        [JsonProperty("search")]
        public string Search { get; set; }
        [JsonProperty("transfer_date")]
        public string TransferDate { get; set; }
        [JsonProperty("units")]
        public string Units { get; set; }
        [JsonProperty("price")]
        public string Price { get; set; }
        [JsonProperty("btc1krw")]
        public string Btc1Krw { get; set; }
        [JsonProperty("fee")]
        public string Fee { get; set; }
        [JsonProperty("btc_remain")]
        public string BtcRemain { get; set; }
        [JsonProperty("krw_remain")]
        public string KrwRemain { get; set; }
    }
}
