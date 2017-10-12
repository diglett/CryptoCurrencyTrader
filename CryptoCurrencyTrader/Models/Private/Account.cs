using System;
using CryptoCurrencyTrader.Utils;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Account
    {
        [JsonProperty("created")]
        public long CreatedTimeStamp { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("trade_fee")]
        public double TradeFee { get; set; }
        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonIgnore]
        public DateTime FormattedDateTime
        {
            get
            {
                return CommonFunctions.ConvertUnixTimeStampToDateTime(CreatedTimeStamp);
            }
        }
    }
}
