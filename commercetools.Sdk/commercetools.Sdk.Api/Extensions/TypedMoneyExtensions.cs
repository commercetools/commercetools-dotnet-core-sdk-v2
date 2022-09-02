using System;
using System.Globalization;

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
    }
}