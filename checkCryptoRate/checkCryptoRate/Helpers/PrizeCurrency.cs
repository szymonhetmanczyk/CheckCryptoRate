using CheckCryptoRate.Interfaces;
using CheckCryptoRate.Models;
using System;

namespace CheckCryptoRate.Helpers
{
    public class PrizeCurrency : IPrizeCurrency
    {
        public void ShowPrizeCurrency(BitCoinPrizeData bitCoinPrizeData, string cryptocurrency, CurrencyType currency)
        {
            Console.WriteLine("Cryptocurrency: {0}", cryptocurrency);
            Console.WriteLine("Currency: {0}\n", currency);

            Console.WriteLine("Max = {0}", bitCoinPrizeData.Max);
            Console.WriteLine("Min = {0}", bitCoinPrizeData.Min);
            Console.WriteLine("Bid = {0}", bitCoinPrizeData.Bid);
            Console.WriteLine("Ask = {0}", bitCoinPrizeData.Ask);
            Console.WriteLine("Vwap = {0}", bitCoinPrizeData.Vwap);
            Console.WriteLine("Average = {0}\n", bitCoinPrizeData.Average);
        }

        public void ShowExplanation()
        {
            string max = "Max is the price of the deal with the highest value\n";
            string min = "Min is the price of the transaction with the lowest value\n";
            string bid = "The bid is the best rate for the current bid\n";
            string ask = "Ask is the best rate for the current sale offers\n";
            string vwap = "Vwap is the weighted average over the last 24 hours\n";
            string average = "Average is the average price calculated from the 3 best sale offers\n";

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(bid);
            Console.WriteLine(ask);
            Console.WriteLine(vwap);
            Console.WriteLine(average);
        }



    }
}
