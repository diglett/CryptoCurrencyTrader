using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Order
    {
        [JsonProperty("order_id")]
        public string OrderID { get; set; }
        [JsonProperty("order_currency")]
        public string OrderCurrency { get; set; }
        [JsonProperty("order_date")]
        public string OrderDate { get; set; }
        [JsonProperty("payment_currency")]
        public string PaymentCurrency { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("units")]
        public string Units { get; set; }
        [JsonProperty("units_remaining")]
        public string UnitsRemaining { get; set; }
        [JsonProperty("price")]
        public string Price { get; set; }
        [JsonProperty("misu_yn")]
        public string MisuYN { get; set; }
        [JsonProperty("fee")]
        public string Fee { get; set; }
        [JsonProperty("total")]
        public string Total { get; set; }
        [JsonProperty("date_completed")]
        public string DateCompleted { get; set; }
    }
}
