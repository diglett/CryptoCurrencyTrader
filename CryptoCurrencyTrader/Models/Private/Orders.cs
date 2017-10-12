using System.Collections.Generic;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Orders
    {
        public string Status { get; set; }

        public List<Order> Data { get; set; }
    }
}
