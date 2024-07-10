using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ItemShippingTarget))]
    public partial interface IItemShippingTarget
    {
        string AddressKey { get; set; }

        long Quantity { get; set; }

        string ShippingMethodKey { get; set; }

    }
}
