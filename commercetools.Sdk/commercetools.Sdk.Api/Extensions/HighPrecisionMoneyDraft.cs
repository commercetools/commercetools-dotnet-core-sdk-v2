using System;

namespace commercetools.Sdk.Api.Models.Common
{
    public partial class HighPrecisionMoneyDraft : IHighPrecisionMoneyDraft
    {
        int? ITypedMoneyDraft.FractionDigits { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static IHighPrecisionMoneyDraft FromDecimal(string currencyCode, decimal value, int fractionDigits, MidpointRounding midpointRounding = MidpointRounding.ToEven)
        {
            var amount = Math.Round(value * (decimal)Math.Pow(10, fractionDigits), 0, midpointRounding);
            var centAmount = Math.Round(value * 100, 0, midpointRounding);
            return new HighPrecisionMoneyDraft
            {
                CurrencyCode = currencyCode,
                PreciseAmount = (long)amount,
                CentAmount = (long)centAmount,
                FractionDigits = fractionDigits
            };
        }
    }
}