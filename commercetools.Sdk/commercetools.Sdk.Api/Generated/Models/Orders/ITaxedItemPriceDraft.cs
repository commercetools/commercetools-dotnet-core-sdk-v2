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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.TaxedItemPriceDraft))]
    public partial interface ITaxedItemPriceDraft
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

    }
}
