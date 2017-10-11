using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader
{
    public class BithumbAPI
    {
        private const string _API_URL = "https://api.bithumb.com";

        // API Connect Key : b440f67ffbe9fed16693caa5a0d53002
        // Secret Key : d02be90f1a46885cc31fd87690117426

        private string _apiKey = "b440f67ffbe9fed16693caa5a0d53002";
        private string _apiSecret = "d02be90f1a46885cc31fd87690117426";

        public BithumbAPI(string apiKey, string apiSecret)
        {
            _apiKey = apiKey;
            _apiSecret = apiSecret;
        }

        #region Public API

        public async Task<ApiResult<Ticker>> GetTickerAsync(string currency)
        {

        }

        public async Task<ApiResult<OrderBook>> GetOrderBookAsync(string currency)
        {

        }

        public async Task<ApiResult<RecentTransactions>> GetRecentTransactionsAsync(string currency)
        {

        }

        #endregion


    }
}
