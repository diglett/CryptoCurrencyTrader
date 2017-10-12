using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyTrader.Models.Enums;

namespace CryptoCurrencyTrader.Models.Request
{
    public class OrderHistoryRequest : RequestBase
    {
        public string order_id { get; set; }
        public string type { get; set; }
        public int count { get; set; } = 100;
        public int after { get; set; } = (int)DateTime.Now.TimeOfDay.Ticks;
        public string currency { get; set; } = CurrencyType.BTC.ToString();
    }
}
