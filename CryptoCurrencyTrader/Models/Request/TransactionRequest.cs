using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyTrader.Models.Enums;

namespace CryptoCurrencyTrader.Models.Request
{
    public class TransactionRequest : RequestBase
    {
        public int offset { get; set; } = 0;
        public int count { get; set; } = 20;
        public string searchGb { get; set; } = "0";
        public string currency { get; set; } = CurrencyType.BTC.ToString();
    }
}
