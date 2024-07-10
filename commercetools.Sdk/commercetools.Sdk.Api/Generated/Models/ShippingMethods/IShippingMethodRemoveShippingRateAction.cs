using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction))]
    public partial interface IShippingMethodRemoveShippingRateAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

    }
}
