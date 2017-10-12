using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Models.Enums
{
    public class TransactionSearchType
    {
        /// <summary>
        /// 0 : 전체 
        /// </summary>
        public const string ALL = "0";
        /// <summary>
        /// 1 : 구매완료
        /// </summary>
        public const string BuyCompleted = "1";
        /// <summary>
        /// 2 : 판매완료
        /// </summary>
        public const string SellCompleted = "2";
        /// <summary>
        /// 3 : 출금중
        /// </summary>
        public const string NowWithdrawing = "3";
        /// <summary>
        /// 4 : 입금
        /// </summary>
        public const string DepositCompleted = "4";
        /// <summary>
        /// 5 : 출금
        /// </summary>
        public const string WithdrawCompleted = "5";
        /// <summary>
        /// 9 : KRW 입금중
        /// </summary>
        public const string NowKRWWithdrawing = "9";
    }
}
