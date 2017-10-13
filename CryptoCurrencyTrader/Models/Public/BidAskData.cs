using Newtonsoft.Json.Linq;

namespace CryptoCurrencyTrader.Models.Public
{
    public class BidAskData
    {
        public double Quantity { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            var jsonObject = new JObject
            {
                {"Quantity", Quantity},
                {"Price", Price}
            };

            return jsonObject.ToString();
        }
    }
}
