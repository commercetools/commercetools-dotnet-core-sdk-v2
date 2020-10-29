using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodAddZoneAction))]
    public interface IShippingMethodAddZoneAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set;}
    }
}
