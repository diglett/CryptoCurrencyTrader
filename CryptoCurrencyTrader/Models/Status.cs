using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoCurrencyTrader.Models
{
    public class RequestStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
