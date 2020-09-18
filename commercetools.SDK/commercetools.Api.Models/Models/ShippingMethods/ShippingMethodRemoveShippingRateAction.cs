using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("removeShippingRate")]
    public class ShippingMethodRemoveShippingRateAction : ShippingMethodUpdateAction
    {
        public ZoneResourceIdentifier Zone { get; set;}
        
        public ShippingRateDraft ShippingRate { get; set;}
    }
}
