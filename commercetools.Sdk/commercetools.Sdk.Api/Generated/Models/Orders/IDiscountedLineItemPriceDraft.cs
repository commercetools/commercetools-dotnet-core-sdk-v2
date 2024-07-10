using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
