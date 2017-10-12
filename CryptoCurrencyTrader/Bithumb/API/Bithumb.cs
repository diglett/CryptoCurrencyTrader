using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;
using CryptoCurrencyTrader.Models;
using CryptoCurrencyTrader.Models.Enums;
using CryptoCurrencyTrader.Models.Private;
using CryptoCurrencyTrader.Models.Public;
using CryptoCurrencyTrader.Models.Request;
using Newtonsoft.Json.Linq;
using Ticker = CryptoCurrencyTrader.Models.Public.Ticker;

namespace CryptoCurrencyTrader
{
    public class Bithumb
    {
        private const string _API_URL = "https://api.bithumb.com";

        // API Connect Key : b440f67ffbe9fed16693caa5a0d53002
        // Secret Key : d02be90f1a46885cc31fd87690117426
        private string _apiKey = "b440f67ffbe9fed16693caa5a0d53002";
        private string _apiSecretKey = "d02be90f1a46885cc31fd87690117426";

        public Bithumb(string apiKey, string apiSecret)
        {
            _apiKey = apiKey;
            _apiSecretKey = apiSecret;
        }

        #region Public API

        public async Task<Ticker> GetTickerAsync(string currency)
        {
            return await RestClient.Instance.GetAsync<Ticker>(PublicAPI.Ticker.Replace("{currency}", currency));
        }

        public async Task<OrderBook> GetOrderBookAsync(string currency)
        {
            return await RestClient.Instance.GetAsync<OrderBook>(PublicAPI.OrderBook.Replace("{currency}", currency));
        }

        public async Task<Transactions> GetRecentTransactionsAsync(string currency)
        {
            return await RestClient.Instance.GetAsync<Transactions>(PublicAPI.RecentTrasactions.Replace("{currency}", currency));
        }

        #endregion

        #region Private API

        public async Task<Account> GetAccountAsync(string currency)
        {
            var request = new JObject
            {
                { "currency", currency }
            };

            return await RestClient.Instance.PostAsync<JObject, Account>(PrivateAPI.Account, request);
        }

        public async Task<Balance> GetBalanceAsync(string currency)
        {
            var request = new JObject
            {
                { "currency", currency }
            };

            return await RestClient.Instance.PostAsync<JObject, Balance>(PrivateAPI.Balance, request);
        }

        public async Task<WalletAddress> GetWalletAddressAsync(string currency)
        {
            var request = new JObject
            {
                { "currency", currency }
            };

            return await RestClient.Instance.PostAsync<JObject, WalletAddress>(PrivateAPI.WalletAddress, request);
        }

        public async Task<Ticker> GetTickerAsync(string orderCurrency, string paymentCurrency)
        {
            var request = new JObject
            {
                { "order_currency", orderCurrency },
                { "payment_currency", paymentCurrency }
            };

            return await RestClient.Instance.PostAsync<JObject, Ticker>(PrivateAPI.Ticker, request);
        }

        public async Task<Orders> GetOrdersAsync(string orderID, string transactionType, int count, int after, CurrencyType currency)
        {
            var request = new OrderHistoryRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                order_id = orderID,
                type = transactionType,
                count = count,
                after = after,
                currency = currency.ToString()
            };

            return await RestClient.Instance.PostAsync<OrderHistoryRequest, Orders>(PrivateAPI.Orders, request);
        }

        public async Task<UserTransactions> GetUserTransactionAsync(int offset, int count, string searchGb, CurrencyType currency)
        {
            var request = new TransactionRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                offset = offset,
                count = count,
                searchGb = searchGb,
                currency = currency.ToString()
            };

            return await RestClient.Instance.PostAsync<TransactionRequest, UserTransactions>(PrivateAPI.UserTransactions, request);
        }

        public async Task<Trades> GetPlacesAsync(CurrencyType orderCurrency, CurrencyType paymentCurrency, float units, int price, string type, string misu)
        {
            var request = new TradeRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                order_currency = orderCurrency.ToString(),
                payment_currency = paymentCurrency.ToString(),
                units = units,
                price = price,
                type = type,
                misu = misu
            };

            return await RestClient.Instance.PostAsync<TradeRequest, Trades>(PrivateAPI.Place, request);
        }

        public async Task<OrderDetails> GetOrderDetailAsync(string type, string orderID, string currency)
        {
            var request = new OrderRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                type = type,
                order_id = orderID,
                currency = currency
            };

            return await RestClient.Instance.PostAsync<OrderRequest, OrderDetails>(PrivateAPI.OrderDetail, request);
        }

        public async Task<RequestStatus> CancelAsync(string type, string orderID, string currency)
        {
            var request = new OrderRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                type = type,
                order_id = orderID,
                currency = currency
            };

            return await RestClient.Instance.PostAsync<OrderRequest,RequestStatus>(PrivateAPI.Cancel, request);
        }

        public async Task<RequestStatus> WithdrawCryptoCurrencyAsync(string units, string address, string destinaion, CurrencyType currency)
        {
            if (currency == CurrencyType.XRP)
            {
                int xrpDestination = 0;

                int.TryParse(destinaion, out xrpDestination);

                var request = new XRPWithdrawalRequest
                {
                    apiKey = _apiKey,
                    secretKey = _apiSecretKey,
                    units = units,
                    address = address,
                    currency = currency.ToString(),
                    destination = xrpDestination
                };

                return await RestClient.Instance.PostAsync<XRPWithdrawalRequest, RequestStatus>(PrivateAPI.Cancel, request);
            }
            else
            {
                var request = new CryptoCurrencyWithdrawalRequest
                {
                    apiKey = _apiKey,
                    secretKey = _apiSecretKey,
                    units = units,
                    address = address,
                    currency = currency.ToString(),
                    destination = destinaion
                };

                return await RestClient.Instance.PostAsync<CryptoCurrencyWithdrawalRequest, RequestStatus>(PrivateAPI.Cancel, request);
            }
        }

        public async Task<RequestStatus> GetDepositInfoAsync()
        {
            var request = new RequestBase
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey
            };

            return await RestClient.Instance.PostAsync<RequestBase, RequestStatus>(PrivateAPI.Deposit, request);
        }

        public async Task<RequestStatus> WithdrawKRWAsync(string bankCode, string account, int price)
        {
            var request = new KRWWithdrawalRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                bank = bankCode,
                account = account,
                price = price
            };

            return await RestClient.Instance.PostAsync<KRWWithdrawalRequest, RequestStatus>(PrivateAPI.Deposit, request);
        }

        public async Task<Trades> BuyByMarketPriceAsync(string units, string currency)
        {
            var request = new BuySellRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                units = units,
                currency = currency,
            };

            return await RestClient.Instance.PostAsync<BuySellRequest, Trades>(PrivateAPI.Deposit, request);
        }

        public async Task<Trades> SellByMarketPriceAsync(string units, string currency)
        {
            var request = new BuySellRequest
            {
                apiKey = _apiKey,
                secretKey = _apiSecretKey,
                units = units,
                currency = currency,
            };

            return await RestClient.Instance.PostAsync<BuySellRequest, Trades>(PrivateAPI.Deposit, request);
        }

        #endregion
    }
}
