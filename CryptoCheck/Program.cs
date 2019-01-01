using ConsoleApp1.Helpers;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;

            DateTime dt = DateTime.Now;
            var dat = String.Format("{0:G}\n", dt);
            Console.WriteLine(dat);

            GetPrizeCurrency getPrizeCurrency = new GetPrizeCurrency();
            ConnectApi connectApi = new ConnectApi();
            GetHelpData getHelpData = new GetHelpData();

            var list = getHelpData.GetListCryptocurrency();

            getPrizeCurrency.ShowExplanation();

            foreach (var i in list)
            {
                BitCoinPrizeData bitCoinPrizeDataInPln = connectApi.GetCryptocurrencyData(i, Currency.PLN);
                BitCoinPrizeData bitCoinPrizeDataInUsd = connectApi.GetCryptocurrencyData(i, Currency.USD);
                BitCoinPrizeData bitCoinPrizeDataInEur = connectApi.GetCryptocurrencyData(i, Currency.EUR);

                getPrizeCurrency.ShowPrizeCurrency(bitCoinPrizeDataInPln, i, Currency.PLN);
                getPrizeCurrency.ShowPrizeCurrency(bitCoinPrizeDataInUsd, i, Currency.USD);
                getPrizeCurrency.ShowPrizeCurrency(bitCoinPrizeDataInEur, i, Currency.EUR);
            }

            DateTime stopTime = DateTime.Now;
            TimeSpan roznica = stopTime - startTime;
            Console.WriteLine("Czas pracy: {0} ms", roznica.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
