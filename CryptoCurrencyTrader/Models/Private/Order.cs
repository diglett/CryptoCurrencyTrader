using System;
using CryptoCurrencyTrader.Utils;
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
        public long OrderDateTime { get; set; }
        [JsonProperty("payment_currency")]
        public string PaymentCurrency { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("units")]
        public double Units { get; set; }
        [JsonProperty("units_remaining")]
        public double UnitsRemaining { get; set; }
        [JsonProperty("price")]
        public long Price { get; set; }
        [JsonProperty("misu_yn")]
        public string MisuYN { get; set; }
        [JsonProperty("fee")]
        public double? Fee { get; set; }
        [JsonProperty("total")]
        public long? Total { get; set; }
        [JsonProperty("date_completed")]
        public long? CompletedDateTime { get; set; }

        [JsonIgnore]
        public bool IsCompletedOrder
        {
            get { return CompletedDateTime != null; }
        }

        [JsonIgnore]
        public DateTime FormattedOrderDateTime
        {
            get
            {
                return CommonFunctions.ConvertUnixTimeStampToDateTime(OrderDateTime);
            }
        }

        [JsonIgnore]
        public DateTime? FormattedCompletedDateTime
        {
            get
            {
                if (IsCompletedOrder)
                    return null;

                return CommonFunctions.ConvertUnixTimeStampToDateTime((long)CompletedDateTime);
            }
        }
    }
}
