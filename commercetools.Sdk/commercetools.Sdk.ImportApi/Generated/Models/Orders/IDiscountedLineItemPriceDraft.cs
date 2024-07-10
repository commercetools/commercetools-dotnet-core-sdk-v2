using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
