using System;
using CryptoCurrencyTrader.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoCurrencyTrader.Models.Public
{
    public class TickerData
    {
        [JsonProperty("opening_price")]
        public int OpeningPrice { get; set; }

        [JsonProperty("closing_price")]
        public int ClosingPrice { get; set; }

        [JsonProperty("min_price")]
        public int MinPrice { get; set; }

        [JsonProperty("max_price")]
        public int MaxPrice { get; set; }

        [JsonProperty("average_price")]
        public double AveragePrice { get; set; }

        [JsonProperty("units_traded")]
        public double UnitsTraded { get; set; }

        [JsonProperty("volume_1day")]
        public double Volume1Day { get; set; }

        [JsonProperty("volume_7day")]
        public double Volume7Day { get; set; }

        [JsonProperty("buy_price")]
        public int BuyPrice { get; set; }

        [JsonProperty("sell_price")]
        public int SellPrice { get; set; }

        [JsonProperty("date")]
        public long TimeStamp { get; set; }

        [JsonIgnore]
        public DateTime FormattedDateTime
        {
            get
            {
                return CommonFunctions.ConvertUnixTimeStampToDateTime(TimeStamp);
            }
        }
        
        public override string ToString()
        {
            JObject jsonObject = new JObject
            {
                {"OpeningPrice", OpeningPrice},
                {"ClosingPrice", ClosingPrice},
                {"MinPrice", MinPrice},
                {"MaxPrice", MaxPrice},
                {"UnitsTraded", UnitsTraded},
                {"Volume1Day", Volume1Day},
                {"Volume7Day", Volume7Day},
                {"BuyPrice", BuyPrice},
                {"SellPrice", SellPrice},
                {"FormattedDateTime", FormattedDateTime.ToString("yyyy-MM-dd HH:mm:ss")}
            };

            return $"Ticker:\r\n{jsonObject.ToString()}";
        }
    }
}
