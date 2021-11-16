using System;

namespace commercetools.Api.Models.Common
{
    public partial class Money
    {
        public static IMoney FromDecimal(string currencyCode, decimal value, MidpointRounding midpointRounding = MidpointRounding.ToEven)
        {
            var amount = Math.Round(value * 100M, 0, midpointRounding);
            return new Money()
            {
                CurrencyCode = currencyCode,
                CentAmount = (long)amount
            };
        }
    }
}