using System;
using commercetools.Api.Models.Common;

namespace commercetools.Api.Models.Common
{
    public static class TypedMoneyExtensions
    {
        public static decimal AmountToDecimal(this ITypedMoney typedMoney)
        {
            if (typedMoney is IHighPrecisionMoney highPrecisionMoney)
            {
                return highPrecisionMoney.PreciseAmount / (decimal)Math.Pow(10, highPrecisionMoney.FractionDigits );
            }
            return typedMoney.CentAmount / 100M;
        }
    }
}