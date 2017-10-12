using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Public
{
    public class Transactions
    {
        public string Status { get; set; }
        public List<Transaction> Data { get; set; }
    }
}
