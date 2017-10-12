using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyTrader.Utils;
using Newtonsoft.Json;

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
    }
}
