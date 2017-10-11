using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader
{
    public class PublicAPI : BaseAPI
    {
        private const string Public = Base + "/public";

        public const string Ticker = Public + "/ticker/{currency}";
        private const string OrderBook = Public + "/orderbook/{currency}";
        private const string RecentTrasactions = Public + "/recent_transactions/{currency}";
    }
}
