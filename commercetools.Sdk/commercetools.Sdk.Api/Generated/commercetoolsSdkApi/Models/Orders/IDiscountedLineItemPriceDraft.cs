using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.DiscountedLineItemPriceDraft))]
    public partial interface IDiscountedLineItemPriceDraft
    {
        IMoney Value { get; set; }

        IList<IDiscountedLineItemPortionDraft> IncludedDiscounts { get; set; }

        IEnumerable<IDiscountedLineItemPortionDraft> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }

    }
}
