using System;

namespace commercetools.Sdk.Api.Models.Common
{
    public static class TypedMoneyExtensions
    {
        public static decimal AmountToDecimal(this ITypedMoney typedMoney)
        {
            if (typedMoney is IHighPrecisionMoney highPrecisionMoney)
            {
                return highPrecisionMoney.PreciseAmount / (decimal)Math.Pow(10, highPrecisionMoney.FractionDigits);
            }
            return typedMoney.CentAmount / (decimal)Math.Pow(10, typedMoney.FractionDigits);
        }
        
        public static IHighPrecisionMoneyDraft ToDraft(this IHighPrecisionMoney highPrecisionMoney)
        {
            return new HighPrecisionMoneyDraft()
            {
                CurrencyCode = highPrecisionMoney.CurrencyCode,
                CentAmount = highPrecisionMoney.CentAmount,
                PreciseAmount = highPrecisionMoney.PreciseAmount,
                FractionDigits = highPrecisionMoney.FractionDigits
            };
        }
        
        public static ICentPrecisionMoneyDraft ToDraft(this ICentPrecisionMoney highPrecisionMoney)
        {
            return new CentPrecisionMoneyDraft()
            {
                CurrencyCode = highPrecisionMoney.CurrencyCode,
                CentAmount = highPrecisionMoney.CentAmount,
                FractionDigits = highPrecisionMoney.FractionDigits
            };
        }
        
        public static ITypedMoneyDraft ToDraft(this ITypedMoney money)
        {
            if (money is IHighPrecisionMoney)
            {
                return ((HighPrecisionMoney)money).ToDraft();
            }

            return ((CentPrecisionMoney)money).ToDraft();
        }
    }
}