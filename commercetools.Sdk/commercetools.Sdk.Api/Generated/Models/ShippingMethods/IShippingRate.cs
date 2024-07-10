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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingRate))]
    public partial interface IShippingRate
    {
        ICentPrecisionMoney Price { get; set; }

        ICentPrecisionMoney FreeAbove { get; set; }

        bool? IsMatching { get; set; }

        IList<IShippingRatePriceTier> Tiers { get; set; }
        IEnumerable<IShippingRatePriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


    }
}
