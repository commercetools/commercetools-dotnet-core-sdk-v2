using System;

namespace commercetools.Api.Models.Common
{
    public partial class HighPrecisionMoney
    {
        public override decimal AmountToDecimal()
        {
            return PreciseAmount / (decimal)Math.Pow(10, FractionDigits );
        }
        
        public static HighPrecisionMoney FromDecimal(string currencyCode, decimal value, int fractionDigits, MidpointRounding midpointRounding = MidpointRounding.ToEven)
        {
            var amount = Math.Round(value * (decimal) Math.Pow(10, fractionDigits), 0, midpointRounding);
            var centAmount = Math.Round(value * 100, 0, midpointRounding);
            return new HighPrecisionMoney
            {
                CurrencyCode = currencyCode,
                PreciseAmount = (long)amount,
                CentAmount = (long)centAmount,
                FractionDigits = fractionDigits
            };
        }
    }
}