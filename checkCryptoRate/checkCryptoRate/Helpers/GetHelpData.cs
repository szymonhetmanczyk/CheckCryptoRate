using checkCryptoRate.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace checkCryptoRate.Helpers
{
    public class GetHelpData
    {
        public List<String> GetListCryptocurrency()
        {
            List<String> list = new List<String>();
            list.Add(Cryptocurrency.BTC.ToString());
            list.Add(Cryptocurrency.BCC.ToString());
            list.Add(Cryptocurrency.LTC.ToString());
            list.Add(Cryptocurrency.LSK.ToString());
            list.Add(Cryptocurrency.KZC.ToString());
            list.Add(Cryptocurrency.GAME.ToString());
            list.Add(Cryptocurrency.ETH.ToString());
            list.Add(Cryptocurrency.DASH.ToString());
            list.Add(Cryptocurrency.BTG.ToString());

            return list;
        }
    }
}