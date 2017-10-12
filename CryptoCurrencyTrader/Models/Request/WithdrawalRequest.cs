using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Request
{
    public class KRWWithdrawalRequest : RequestBase
    {
        public string bank { get; set; }
        public string account { get; set; }
        public int price { get; set; }
    }
}
