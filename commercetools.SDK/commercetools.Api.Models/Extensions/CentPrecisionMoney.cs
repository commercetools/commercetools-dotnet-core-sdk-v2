using System;

namespace commercetools.Api.Models.Common
{
    public partial class CentPrecisionMoney
    {
        public override decimal AmountToDecimal()
        {
            return this.CentAmount / 100M;
        }
        
        public static CentPrecisionMoney FromDecimal(string currencyCode, decimal value, MidpointRounding midpointRounding = MidpointRounding.ToEven)
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