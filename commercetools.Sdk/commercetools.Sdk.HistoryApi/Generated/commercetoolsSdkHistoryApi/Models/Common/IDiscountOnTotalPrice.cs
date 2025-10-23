using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountOnTotalPrice))]
    public partial interface IDiscountOnTotalPrice
    {
        ITypedMoney DiscountedAmount { get; set; }

        IList<IDiscountedTotalPricePortion> IncludedDiscounts { get; set; }

        IEnumerable<IDiscountedTotalPricePortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

        ITypedMoney DiscountedNetAmount { get; set; }

        ITypedMoney DiscountedGrossAmount { get; set; }

    }
}
