using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Request
{
    public class RequestBase
    {
        public string apiKey { get; set; }

        public string secretKey { get; set; }
    }
}
