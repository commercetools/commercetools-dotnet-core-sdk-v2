using System;

namespace commercetools.Sdk.Api.Models.Common
{
    public partial class CentPrecisionMoneyDraft : ICentPrecisionMoneyDraft
    {
        public static ICentPrecisionMoneyDraft FromDecimal(string currencyCode, decimal value, MidpointRounding midpointRounding = MidpointRounding.ToEven)
        {
            var amount = Math.Round(value * 100M, 0, midpointRounding);
            return new CentPrecisionMoneyDraft
            {
                CurrencyCode = currencyCode,
                CentAmount = (long)amount,
                FractionDigits = 2
            };
        }
        
        public static ICentPrecisionMoneyDraft FromDecimal(string currencyCode, decimal value, int fractionDigits, MidpointRounding midpointRounding = MidpointRounding.ToEven)
        {
            var amount = Math.Round(value * (decimal)Math.Pow(10, fractionDigits), 0, midpointRounding);
            return new CentPrecisionMoneyDraft
            {
                CurrencyCode = currencyCode,
                CentAmount = (long)amount,
                FractionDigits = fractionDigits
            };
        }
    }
}