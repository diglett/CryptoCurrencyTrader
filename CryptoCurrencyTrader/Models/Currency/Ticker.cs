using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader
{
    public class Ticker
    {
        public string Status { get; set; } = string.Empty;

        public TickerData Data { get; set; }
    }
}
