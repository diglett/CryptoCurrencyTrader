using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoCurrencyTrader.Models.Public
{
    public class Transaction
    {
        [JsonProperty("transaction_date")]
        public string TransactionDate { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("units_traded")]
        public double UnitsTraded { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonIgnore]
        public DateTime FormattedTransactionDateTime
        {
            get
            {
                return DateTime.Parse(TransactionDate);
            }
        }

        public override string ToString()
        {
            var jsonObject = new JObject
            {
                {"TransactionDate", TransactionDate},
                {"Type", Type},
                {"UnitsTraded", UnitsTraded},
                {"Price", Price},
                {"Total", Total},
            };

            return $"{jsonObject.ToString()}";
        }
    }
}
