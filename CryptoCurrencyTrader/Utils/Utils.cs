using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTrader.Utils
{
    public static class CommonFunctions
    {
        public static DateTime ConvertUnixTimeStampToDateTime(long timeStamp)
        {
            DateTime startDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            startDateTime = startDateTime.AddSeconds(timeStamp).ToLocalTime();
            return startDateTime;
        }
    }
}
