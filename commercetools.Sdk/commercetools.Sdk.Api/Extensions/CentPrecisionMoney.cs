using System;

namespace commercetools.Api.Models.Common
{
    public partial class CentPrecisionMoney : ICentPrecisionMoney
    {
        public static ICentPrecisionMoney FromDecimal(string currencyCode, decimal value, MidpointRounding midpointRounding = MidpointRounding.ToEven)
        {
            var amount = Math.Round(value * 100M, 0, midpointRounding);
            return new CentPrecisionMoney
            {
                CurrencyCode = currencyCode,
                CentAmount = (long)amount
            };
        }
    }
}