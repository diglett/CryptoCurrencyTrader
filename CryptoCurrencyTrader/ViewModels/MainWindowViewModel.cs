using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CryptoCurrencyTrader.Commands;
using CryptoCurrencyTrader.Models.Enums;
using CryptoCurrencyTrader.Models.Public;

namespace CryptoCurrencyTrader.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            
        }

        #region 커맨드

        public ICommand TickerCommand
        {
            get
            {
                return Get(() => TickerCommand, new RelayCommand(async () =>
                {
                    var result = await Bithumb.GetTickerAsync(CurrencyType.XRP.ToString());

                    if (result != null && result.Status == "0000")
                    {
                        var ticker = result.Data;
                        
                        Console.WriteLine(ticker.ToString());
                    }
                })); 
            }
        }

        public ICommand OrderBookCommand
        {
            get
            {
                return Get(() => OrderBookCommand, new RelayCommand(async () =>
                {
                    var result = await Bithumb.GetOrderBookAsync(CurrencyType.XRP.ToString());

                    if (result != null && result.Status == "0000")
                    {
                        var orderBook = result.Data;

                        Console.WriteLine(orderBook.ToString());
                    }
                }));
            }
        }

        public ICommand RecentTransactionsCommand
        {
            get
            {
                return Get(() => RecentTransactionsCommand, new RelayCommand(async () =>
                {
                    var result = await Bithumb.GetRecentTransactionsAsync(CurrencyType.XRP.ToString());

                    if (result != null && result.Status == "0000")
                    {
                        var orderBook = result.Data;

                        Console.WriteLine(orderBook.ToString());
                    }
                }));
            }
        }

        #endregion
    }
}
