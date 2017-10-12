using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Private
{
    public class OrderDetails
    {
        public string Status { get; set; }

        public List<OrderDetail> Data { get; set; }
    }
}
