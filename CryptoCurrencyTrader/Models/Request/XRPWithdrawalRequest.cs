using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Request
{
    public class XRPWithdrawalRequest : RequestBase
    {
        public string units { get; set; }
        public string address { get; set; }
        public int destination { get; set; }
        public string currency { get; set; }
    }
}
