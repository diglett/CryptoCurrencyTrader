using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Trade
    {
        [JsonProperty("cont_id")]
        public string ContractID { get; set; }
        [JsonProperty("units")]
        public string Units { get; set; }
        [JsonProperty("price")]
        public string Price { get; set; }
        [JsonProperty("total")]
        public string Total { get; set; }
        [JsonProperty("fee")]
        public string Fee { get; set; }
    }
}
