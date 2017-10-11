using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader
{
    public class PrivateAPI : BaseAPI
    {
        #region Info API
        private const string Info = Base + "/info";
        public const string Account = Info + "/account";
        public const string Balance = Info + "/balance";
        public const string WalletAddress = Info + "/wallet_address";
        public const string Ticker = Info + "/ticker";
        public const string Orders = Info + "/orders";
        public const string UserTransactions = Info + "/user_transactions";
        public const string OrderDetail = Info + "/order_detail";
        #endregion

        #region Trade API
        private const string Trade = Base + "/trade";
        public const string Place = Trade + "/place";
        public const string Cancel = Trade + "/cancel";
        public const string BTCWithdrawal = Trade + "/btc_withdrawal";
        public const string KRWDeposit = Trade + "/krw_deposit";
        public const string MarketBuy = Trade + "/market_buy";
        public const string MarketSell = Trade + "/market_sell"; 
        #endregion


    }
}
