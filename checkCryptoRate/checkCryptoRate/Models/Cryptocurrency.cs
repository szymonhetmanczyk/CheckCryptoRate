using CheckCryptoRate.Interfaces;
using System;
using System.Collections.Generic;

namespace CheckCryptoRate.Models
{
    public enum CryptocurrencyType
    {
        BTC = 1,
        BCC = 2,
        LTC = 3,
        ETH = 4,
        LSK = 5,
        GAME = 6,
        DASH = 7,
        BTG = 8,
        KZC = 9
    }

    public class Cryptocurrency : ICryptocurrency
    {
        public List<string> GetCryptocurrencies()
        {
            List<string> result = new List<string>();
            foreach(var crypto in Enum.GetNames(typeof(CryptocurrencyType)))
            {
                result.Add(crypto.ToString());
            }
            return result;
        }
    }
}
