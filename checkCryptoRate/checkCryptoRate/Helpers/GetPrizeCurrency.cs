using checkCryptoRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCryptoRate.Helpers
{
    public class GetPrizeCurrency
    {
        public void ShowPrizeCurrency(BitCoinPrizeData bitCoinPrizeData, string cryptocurrency, Currency currency)
        {
            Console.WriteLine("Kryptowaluta: {0}", cryptocurrency);
            Console.WriteLine("Waluta: {0}\n", currency);

            Console.WriteLine("Max = {0}",bitCoinPrizeData.max);
            Console.WriteLine("Min = {0}", bitCoinPrizeData.min);
            Console.WriteLine("Bid = {0}", bitCoinPrizeData.bid);
            Console.WriteLine("Ask = {0}", bitCoinPrizeData.ask);
            Console.WriteLine("Vwap = {0}", bitCoinPrizeData.vwap);
            Console.WriteLine("Average = {0}\n", bitCoinPrizeData.average);
        }

        public void ShowExplanation()
        {
            string max = "Max jest kursem transakcji, która miała największą wartość\n";
            string min = "Min jest kursem transakcji, która miała najmniejszą wartość\n";
            string bid = "Bid jest najkorzystniejszym kursem aktualnych ofert kupna\n";
            string ask = "Ask jest najkorzystniejszym kursem aktualnych ofert sprzedaży\n";
            string vwap = "Vwap jest średnią ważoną z ostatnich 24 godzin\n";
            string average = "Average jest średnią ceną liczoną z 3 najlepszych ofert sprzedaży\n";

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(bid);
            Console.WriteLine(ask);
            Console.WriteLine(vwap);
            Console.WriteLine(average);
        }



    }
}
