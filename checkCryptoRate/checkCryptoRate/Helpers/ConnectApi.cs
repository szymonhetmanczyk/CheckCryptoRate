using checkCryptoRate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace checkCryptoRate.Helpers
{
    public class ConnectApi
    {
        public BitCoinPrizeData GetCryptocurrencyData(string cryptocurrency, Currency currency)
        {
            var uri = String.Format("https://bitbay.net/API/Public/{0}{1}/ticker.json", cryptocurrency, currency);

            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            var data = client.DownloadString(uri);

            BitCoinPrizeData bitCoinPrizeData = JsonConvert.DeserializeObject<BitCoinPrizeData>(data);

            return bitCoinPrizeData;
        }
    }
}
