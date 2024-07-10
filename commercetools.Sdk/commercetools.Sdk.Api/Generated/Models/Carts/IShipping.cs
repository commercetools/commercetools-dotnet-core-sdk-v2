using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.Shipping))]
    public partial interface IShipping
    {
        string ShippingKey { get; set; }

        IShippingInfo ShippingInfo { get; set; }

        IAddress ShippingAddress { get; set; }

        IShippingRateInput ShippingRateInput { get; set; }

        ICustomFields ShippingCustomFields { get; set; }

    }
}
