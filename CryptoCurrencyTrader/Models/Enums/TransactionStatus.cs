using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Enums
{
    public enum TransactionStatus
    {
        ALL = 0,
        BuyCompleted,
        SellCompleted,
        NowWithdrawing,
        DepositCompleted,
        WithdrawCompleted,
        NowKRWWithdrawing = 9
    }

    public static class TransactionStatusExtensions
    {
        public static string Message(this TransactionStatus status)
        {
            switch (status)
            {
                case TransactionStatus.ALL:
                    return "0";
                case TransactionStatus.BuyCompleted:
                    return "1";
                case TransactionStatus.SellCompleted:
                    return "2";
                case TransactionStatus.NowWithdrawing:
                    return "3";
                case TransactionStatus.DepositCompleted:
                    return "4";
                case TransactionStatus.WithdrawCompleted:
                    return "5";
                case TransactionStatus.NowKRWWithdrawing:
                    return "9";
                default:
                    return "0";
            }
        }
    }
}
