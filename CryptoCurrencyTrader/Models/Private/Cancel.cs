﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models.Private
{
    public class Cancel
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}