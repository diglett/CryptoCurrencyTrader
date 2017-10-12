using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyTrader.Models.Request;

namespace CryptoCurrencyTrader.Models.Private
{
    public class BuySellRequest : RequestBase
    {
        public string units { get; set; }
        public string currency { get; set; }
    }
}
