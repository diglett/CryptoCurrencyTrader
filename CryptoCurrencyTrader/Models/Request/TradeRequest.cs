using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Request
{
    public class TradeRequest : RequestBase
    {
        public string order_currency { get; set; }
        public string payment_currency { get; set; }
        public float units { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public string misu { get; set; }
    }
}
