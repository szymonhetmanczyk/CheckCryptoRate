using CheckCryptoRate.Models;

namespace CheckCryptoRate.Interfaces
{
    public interface IPrizeCurrency
    {
        void ShowPrizeCurrency(BitCoinPrizeData bitCoinPrizeData, string cryptocurrency, CurrencyType currency);
        void ShowExplanation();
    }
}
