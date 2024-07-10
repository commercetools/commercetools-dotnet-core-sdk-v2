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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartScoreTier))]
    public partial interface ICartScoreTier : IShippingRatePriceTier
    {
        int Score { get; set; }

        IMoney Price { get; set; }

        IPriceFunction PriceFunction { get; set; }

        bool? IsMatching { get; set; }

    }
}
