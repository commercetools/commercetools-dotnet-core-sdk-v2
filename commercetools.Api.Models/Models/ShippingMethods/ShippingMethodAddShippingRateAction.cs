using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    public class ShippingMethodAddShippingRateAction : ShippingMethodUpdateAction
    {
        public ZoneResourceIdentifier Zone { get; set;}
        
        public ShippingRateDraft ShippingRate { get; set;}
    }
}
