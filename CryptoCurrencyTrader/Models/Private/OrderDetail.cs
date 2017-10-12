using System;
using CryptoCurrencyTrader.Utils;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class OrderDetail
    {
        [JsonProperty("transaction_date")]
        public long TransactionDateTime { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("order_currency")]
        public string OrderCurrency { get; set; }
        [JsonProperty("payment_currency")]
        public string PaymentCurrency { get; set; }
        [JsonProperty("units_traded")]
        public double UnitsTraded { get; set; }
        [JsonProperty("price")]
        public long Price { get; set; }
        [JsonProperty("fee")]
        public double Fee { get; set; }
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonIgnore]
        public DateTime FormattedTransactionDateTime
        {
            get
            {
                return CommonFunctions.ConvertUnixTimeStampToDateTime(TransactionDateTime);
            }
        }
    }
}
