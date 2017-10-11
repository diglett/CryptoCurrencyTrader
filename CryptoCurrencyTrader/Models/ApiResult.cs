﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader
{
    public class ApiResult<T>
    {
        public bool Status { get; set; }

        public T Data { get; set; }
    }
}