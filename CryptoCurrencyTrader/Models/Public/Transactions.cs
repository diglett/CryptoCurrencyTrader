using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoCurrencyTrader.Models.Public
{
    public class Transactions
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<Transaction> Data { get; set; }

        public override string ToString()
        {
            var transactions = new JArray();

            foreach (var transaction in Data)
            {
                transactions.Add(transaction.ToString());
            }

            var jsonObject = new JObject
            {
                {"Status", Status},
                {"Data", transactions}
            };

            return jsonObject.ToString();
        }
    }
}
