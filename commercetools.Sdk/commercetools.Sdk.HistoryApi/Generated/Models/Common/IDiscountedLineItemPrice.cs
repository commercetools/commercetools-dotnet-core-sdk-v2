using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountedLineItemPrice))]
    public partial interface IDiscountedLineItemPrice
    {
        IMoney Value { get; set; }

        IList<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
        IEnumerable<IDiscountedLineItemPortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }


    }
}
