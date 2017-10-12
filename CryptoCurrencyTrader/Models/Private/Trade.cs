using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Trade
    {
        [JsonProperty("cont_id")]
        public string ContractID { get; set; }
        [JsonProperty("units")]
        public double Units { get; set; }
        [JsonProperty("price")]
        public long Price { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("fee")]
        public double Fee { get; set; }
    }
}
