﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Public
{
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public string Type { get; set; }
        public string UnitsTraded { get; set; }
        public string Price { get; set; }
        public string Total { get; set; }
    }
}