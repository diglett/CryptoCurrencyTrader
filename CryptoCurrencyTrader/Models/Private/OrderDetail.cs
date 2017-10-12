using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class OrderDetail
    {
        [JsonProperty("transaction_date")]
        public string TransactionDate { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("order_currency")]
        public string OrderCurrency { get; set; }
        [JsonProperty("payment_currency")]
        public string PaymentCurrency { get; set; }
        [JsonProperty("units_traded")]
        public string UnitsTraded { get; set; }
        [JsonProperty("price")]
        public string Price { get; set; }
        [JsonProperty("fee")]
        public string Fee { get; set; }
        [JsonProperty("total")]
        public string Total { get; set; }
    }
}
