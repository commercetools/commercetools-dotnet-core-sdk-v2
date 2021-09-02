using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction))]
    public partial interface IShippingMethodRemoveZoneAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }
    }
}
