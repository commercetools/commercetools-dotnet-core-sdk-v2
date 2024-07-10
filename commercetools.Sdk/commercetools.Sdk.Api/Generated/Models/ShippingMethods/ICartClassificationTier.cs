using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartClassificationTier))]
    public partial interface ICartClassificationTier : IShippingRatePriceTier
    {
        string Value { get; set; }

        IMoney Price { get; set; }

        bool? IsMatching { get; set; }

    }
}
