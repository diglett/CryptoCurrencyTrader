using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Request
{
    public class OrderRequest : RequestBase
    {
        public string type { get; set; }
        public string order_id { get; set; }
        public string currency { get; set; }
    }
}
