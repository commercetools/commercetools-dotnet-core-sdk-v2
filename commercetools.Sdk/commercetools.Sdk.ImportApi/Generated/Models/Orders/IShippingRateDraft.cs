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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ShippingRateDraft))]
    public partial interface IShippingRateDraft
    {
        IMoney Price { get; set; }

        IMoney FreeAbove { get; set; }

        IList<IShippingRatePriceTier> Tiers { get; set; }
        IEnumerable<IShippingRatePriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


    }
}
