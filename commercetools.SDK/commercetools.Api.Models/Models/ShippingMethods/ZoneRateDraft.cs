using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public class ZoneRateDraft 
    {
        public ZoneResourceIdentifier Zone { get; set;}
        
        public List<ShippingRateDraft> ShippingRates { get; set;}
    }
}
