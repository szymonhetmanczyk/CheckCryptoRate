using CheckCryptoRate.Api;
using CheckCryptoRate.Helpers;
using CheckCryptoRate.Interfaces;
using CheckCryptoRate.Models;
using System;

namespace CheckCryptoRate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;

            DateTime dt = DateTime.Now;
            var date = String.Format("{0:G}\n", dt);
            Console.WriteLine(date);

            IPrizeCurrency getPrizeCurrency = new PrizeCurrency();
            ConnectApi connectApi = new ConnectApi();
            ICryptocurrency crypto = new Cryptocurrency();
            var cryptocurrencies = crypto.GetCryptocurrencies();

            getPrizeCurrency.ShowExplanation();

            foreach (var cryptocurrency in cryptocurrencies)
            {
                BitCoinPrizeData bitCoinPrizeDataInPln = connectApi.GetCryptocurrencyData(cryptocurrency, CurrencyType.PLN);
                BitCoinPrizeData bitCoinPrizeDataInUsd = connectApi.GetCryptocurrencyData(cryptocurrency, CurrencyType.USD);
                BitCoinPrizeData bitCoinPrizeDataInEur = connectApi.GetCryptocurrencyData(cryptocurrency, CurrencyType.EUR);

                getPrizeCurrency.ShowPrizeCurrency(bitCoinPrizeDataInPln, cryptocurrency, CurrencyType.PLN);
                getPrizeCurrency.ShowPrizeCurrency(bitCoinPrizeDataInUsd, cryptocurrency, CurrencyType.USD);
                getPrizeCurrency.ShowPrizeCurrency(bitCoinPrizeDataInEur, cryptocurrency, CurrencyType.EUR);
            }

            DateTime stopTime = DateTime.Now;
            TimeSpan time = stopTime - startTime;
            Console.WriteLine("Czas pracy: {0} ms", time.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
