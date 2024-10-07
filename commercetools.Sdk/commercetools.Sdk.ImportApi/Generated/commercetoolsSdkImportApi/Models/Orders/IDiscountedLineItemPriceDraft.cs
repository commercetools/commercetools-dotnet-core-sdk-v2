using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.DiscountedLineItemPriceDraft))]
    public partial interface IDiscountedLineItemPriceDraft
    {
        IMoney Value { get; set; }

        IList<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }

        IEnumerable<IDiscountedLineItemPortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

    }
}
